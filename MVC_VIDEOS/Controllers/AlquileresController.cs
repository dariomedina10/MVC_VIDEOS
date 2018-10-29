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
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alquileres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alquileres/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alquileres/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Alquileres/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alquileres/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alquileres/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
