using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatalogoDDD.MVC.Controllers
{
    public class AnunciosController : Controller
    {
        // GET: Anuncios
        public ActionResult Index()
        {
            return View();
        }

        // GET: Anuncios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Anuncios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anuncios/Create
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

        // GET: Anuncios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Anuncios/Edit/5
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

        // GET: Anuncios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Anuncios/Delete/5
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
