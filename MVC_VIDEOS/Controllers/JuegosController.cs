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
    public class JuegosController : Controller
    {
        // GET: Juegos
        private bd_video_juegosEntities db = new bd_video_juegosEntities();
        public ActionResult Index()
        {
            ViewBag.juegos = db.juegos.ToList();

            return View();
        }

        // GET: Juegos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var juegos = db.juegos.Find(id);
            if (juegos == null)
            {
                return HttpNotFound();
            }

            return View(juegos);

        }

        // GET: Juegos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juegos/Create
        [HttpPost]
        public ActionResult Create(juegos juegos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.juegos.Add(juegos);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(juegos);
            }
            catch
            {
                return View(juegos);
            }
        }

        // GET: Juegos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var juegos = db.juegos.Find(id);
            if (juegos == null)
            {
                return HttpNotFound();
            }

            return View(juegos);

        }

        // POST: Juegos/Edit/5
        [HttpPost]
        public ActionResult Edit(juegos juegos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(juegos).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(juegos);
            }
            catch
            {
                return View(juegos);
            }

        }

        // GET: Juegos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var juegos = db.juegos.Find(id);
            if (juegos == null)
            {
                return HttpNotFound();
            }

            return View(juegos);

        }

        // POST: Juegos/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, juegos juegos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    juegos = db.juegos.Find(id);
                    if (juegos == null)
                    {
                        return HttpNotFound();
                    }

                    db.juegos.Remove(juegos);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(juegos);
            }
            catch
            {
                return View(juegos);
            }
        }

    }
}

