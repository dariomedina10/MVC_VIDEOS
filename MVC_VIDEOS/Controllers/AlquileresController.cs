using MVC_VIDEOS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;


namespace MVC_VIDEOS.Controllers
{
    public class AlquileresController : Controller
    {
        // GET: Alquileres
        // instancia del objeto entity framework
        private bd_video_juegosEntities db = new bd_video_juegosEntities();
        public ActionResult Index()
        {
            ViewBag.alquileres = db.alquileres.ToList();

            return View();
        }

        // GET: Alquileres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var alquileres = db.alquileres.Find(id);
            if (alquileres == null)
            {
                return HttpNotFound();
            }

            return View(alquileres);

        }

        // GET: Alquileres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alquileres/Create
        [HttpPost]
        public ActionResult Create(alquileres alquileres)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.alquileres.Add(alquileres);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(alquileres);
            }
            catch
            {
                return View(alquileres);
            }
        }

        // GET: Alquileres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var alquileres = db.alquileres.Find(id);
            if (alquileres == null)
            {
                return HttpNotFound();
            }

            return View(alquileres);

        }

        // POST: Alquileres/Edit/5
        [HttpPost]
        public ActionResult Edit(alquileres alquileres)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(alquileres).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(alquileres);
            }
            catch
            {
                return View(alquileres);
            }

        }

        // GET: Alquileres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var alquileres = db.alquileres.Find(id);
            if (alquileres == null)
            {
                return HttpNotFound();
            }

            return View(alquileres);

        }

        // POST: Alquileres/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, alquileres alquileres)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    alquileres = db.alquileres.Find(id);
                    if (alquileres == null)
                    {
                        return HttpNotFound();
                    }

                    db.alquileres.Remove(alquileres);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(alquileres);
            }
            catch
            {
                return View(alquileres);
            }

        }
    }
}
