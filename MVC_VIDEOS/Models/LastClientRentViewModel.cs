using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_VIDEOS.Models
{
    public class LastClientRentViewModel
    {
        public Guid Id { get; } = Guid.NewGuid();
        public int id_juego { get; set; }
        public int id_tipo_juego { get; set; }
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cliente => $"{Nombre} {Apellido}";
        public int Cantidad { get; set; }
        public string Juego { get; set; }
        public string Description_juego { get; set; }
        public string tipojuego { get; set; }
        public DateTime fecha_alquiler { get; set; }
    }
}