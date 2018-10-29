﻿using MVC_VIDEOS;
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
        public ActionResult Details(int id)
        {
            return View();
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
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    db.clientes.Add(clientes);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(clientes);

                // return RedirectToAction("Index");
            }
            catch
            {
                return View(clientes);
            }
        }

        // GET: Cientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cientes/Edit/5
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

        // GET: Cientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cientes/Delete/5
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
