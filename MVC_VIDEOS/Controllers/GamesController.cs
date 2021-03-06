﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_VIDEOS;
using MVC_VIDEOS.Models;
using MVC_VIDEOS.Services;

namespace MVC_VIDEOS.Controllers
{
    public class GamesController : Controller
    {
        private bd_video_juegosEntities db = new bd_video_juegosEntities();

        // GET: Games
        public ActionResult Index()
        {
            return View(db.juegos.ToList());
        }

        [HttpPost]
        public ActionResult Search(GameFilterModel model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index");

            return View(GamesDbService.LastClientRent(db, model.cedula));
        }

        // GET: Games/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            juegos juegos = db.juegos.Find(id);
            if (juegos == null)
            {
                return HttpNotFound();
            }
            return View(juegos);
        }

        // GET: Games/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_juego,nombre,descripcion,tipo")] juegos juegos)
        {
            if (ModelState.IsValid)
            {
                db.juegos.Add(juegos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(juegos);
        }

        // GET: Games/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            juegos juegos = db.juegos.Find(id);
            if (juegos == null)
            {
                return HttpNotFound();
            }
            return View(juegos);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LastClientRentViewModel model)
        {
            if (ModelState.IsValid)
            {

                GamesDbService.EditLastClientRent(db, model);
                return RedirectToAction("Index");
            }
            return View(db.juegos);
        }

        // GET: Games/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            juegos juegos = db.juegos.Find(id);
            if (juegos == null)
            {
                return HttpNotFound();
            }
            return View(juegos);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            juegos juegos = db.juegos.Find(id);
            db.juegos.Remove(juegos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
