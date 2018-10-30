using MVC_VIDEOS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace MVC_VIDEOS.Services
{
    public static class GamesDbService
    {
        public static List<LastClientRentViewModel> LastClientRent(bd_video_juegosEntities db, long cedula)
        {
            if (db is null) throw new Exception("db parameter is null");

            var result = db.alquileres.Where(f => f.ci_cliente == cedula)
                        .GroupBy(f => new { f.ci_cliente, f.id_juego })
                        .Select(f => new
                        {
                            f.Key.ci_cliente,
                            f.Key.id_juego,
                            fecha_alquiler = f.Max(g => g.fecha_alquier),
                            cantidad = f.Count()
                        });
            var response = from item in result
                           join cli in db.clientes on item.ci_cliente equals cli.cedula
                           join ju in db.juegos on item.id_juego equals ju.id_juego
                           join tj in db.tipo_juego on ju.tipo equals tj.id_tipo_juego
                           select new LastClientRentViewModel()
                           {
                               id_tipo_juego = ju.tipo.Value,
                               id_juego = item.id_juego.Value,
                               Cedula = cli.cedula,
                               Nombre = cli.nombre,
                               Apellido = cli.apellidos,
                               Juego = ju.nombre,
                               Description_juego = ju.descripcion,
                               tipojuego = tj.descripcion,
                               Cantidad = item.cantidad,
                               fecha_alquiler = item.fecha_alquiler.Value
                           };
            return response.ToList();
        }

        public static void EditLastClientRent(bd_video_juegosEntities db, LastClientRentViewModel model)
        {
            if (db is null) throw new Exception("db parameter is null");
            if (model is null) throw new Exception("model parameter is null");
            var cli = (clientes) null;
            var ju = (juegos) null;
            var tj = (tipo_juego) null;
            var t = db.Database.BeginTransaction();
            try
            {
                cli = db.clientes.FirstOrDefault(f => f.cedula == model.Cedula);
                if (cli != null)
                {
                    cli.nombre = model.Nombre;
                    cli.apellidos = model.Apellido;
                    db.Entry(cli).State = EntityState.Modified;
                }
                ju = db.juegos.FirstOrDefault(f => f.id_juego == model.id_juego);
                if (ju != null)
                {
                    ju.nombre = model.Juego;
                    ju.descripcion = model.Description_juego;
                    db.Entry(ju).State = EntityState.Modified;
                }
                tj = db.tipo_juego.FirstOrDefault(f => f.id_tipo_juego == model.id_tipo_juego);
                if (tj != null)
                {
                    tj.descripcion = model.tipojuego;
                    db.Entry(tj).State = EntityState.Modified;
                }
            }
            catch(Exception)
            {
                t.Rollback();
            }

            t.Commit();
            db.SaveChanges();
        }
    }
}