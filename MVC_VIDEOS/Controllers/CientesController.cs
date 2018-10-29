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
    public class CientesController : Controller

    {
        // GET: Cientes
        // instancia del objeto entity framework
        private bd_video_juegosEntities db = new bd_video_juegosEntities();
        public ActionResult Index()
        {
            ViewBag.clientes = db.clientes.ToList();

            return View();
            
        }

        // GET: Cientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var clientes = db.clientes.Find(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }

            return View(clientes);


        }

        // GET: Cientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cientes/Create
        [HttpPost]
        public ActionResult Create(clientes clientes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.clientes.Add(clientes);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(clientes);
            }
            catch
            {
                return View(clientes);
            }
        }

        // GET: Cientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var clientes = db.clientes.Find(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }

            return View(clientes);


        }

        // POST: Cientes/Edit/5
        [HttpPost]
        public ActionResult Edit(clientes clientes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(clientes).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(clientes);
            }
            catch
            {
                return View(clientes);
            }
        }

        // GET: Cientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var clientes = db.clientes.Find(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }

            return View(clientes);


        }

        // POST: Cientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, clientes clientes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    clientes = db.clientes.Find(id);
                    if (clientes == null)
                    {
                        return HttpNotFound();
                    }

                    db.clientes.Remove(clientes);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(clientes);
            }
            catch
            {
                return View(clientes);
            }

        }
    }
}
