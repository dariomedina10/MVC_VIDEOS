using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_VIDEOS.Controllers
{
    public class CientesController : Controller
    {
        // GET: Cientes
        public ActionResult Index()
        { 
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
