using MVC_VIDEOS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_VIDEOS.Controllers
{
    public class TipojuegoController : Controller
    {
        // GET: Tipojuego
        private bd_video_juegosEntities db = new bd_video_juegosEntities();
        public ActionResult Index()
        {
            ViewBag.tipojuego = db.tipo_juego.ToList();

            return View();
        }

        // GET: Tipojuego/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var tipojuego = db.tipo_juego.Find(id);
            if (tipojuego == null)
            {
                return HttpNotFound();
            }

            return View(tipojuego);


        }

        // GET: Tipojuego/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipojuego/Create
        [HttpPost]
        public ActionResult Create(tipo_juego tipo_Juego)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.tipo_juego.Add(tipo_Juego);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(tipo_Juego);
            }
            catch
            {
                return View(tipo_Juego);
            }
        }

        // GET: Tipojuego/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var tipojuego = db.tipo_juego.Find(id);
            if (tipojuego == null)
            {
                return HttpNotFound();
            }

            return View(tipojuego);

        }

        // POST: Tipojuego/Edit/5
        [HttpPost]
        public ActionResult Edit(tipo_juego tipo_Juego)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(tipo_Juego).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(tipo_Juego);
            }
            catch
            {
                return View(tipo_Juego);
            }
        }

        // GET: Tipojuego/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var tipojuego = db.tipo_juego.Find(id);
            if (tipojuego == null)
            {
                return HttpNotFound();
            }

            return View(tipojuego);


        }

        // POST: Tipojuego/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, tipo_juego tipo_juego)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    tipo_juego = db.tipo_juego.Find(id);
                    if (tipo_juego == null)
                    {
                        return HttpNotFound();
                    }

                    db.tipo_juego.Remove(tipo_juego);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(tipo_juego);
            }
            catch
            {
                return View(tipo_juego);
            }

        }
    }
}
