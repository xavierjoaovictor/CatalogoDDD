using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using CatalogoDDD.Application.Interfaces;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.MVC.ViewModels;

namespace CatalogoDDD.MVC.Controllers
{
    public class AnunciosController : Controller
    {

        private readonly IClienteAppService _clienteApp;
        private readonly IAnuncioAppService _anuncioApp;


        public AnunciosController(IAnuncioAppService anuncioApp, IClienteAppService clienteApp)
        {
            _anuncioApp = anuncioApp;
            _clienteApp = clienteApp;
        }
        // GET: Anuncios
        public ActionResult Index()
        {
            var anuncioViewModel = Mapper.Map<IEnumerable<Anuncio>, IEnumerable<AnuncioViewModel>>(_anuncioApp.GetAll());

            return View(anuncioViewModel);
        }

        // GET: Anuncios/Details/5
        public ActionResult Details(int id)
        {
            var anuncio = _anuncioApp.GetById(id);
            var anuncioViewModel = Mapper.Map<Anuncio, AnuncioViewModel>(anuncio);
            return View(anuncioViewModel);
        }

        // GET: Anuncios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anuncios/Create
        [HttpPost] 
        [ValidateAntiForgeryToken]
        public ActionResult Create(AnuncioViewModel anuncio)
        {
            if (!ModelState.IsValid)
                return View(anuncio);

            var novoAnuncio = Mapper.Map<AnuncioViewModel, Anuncio>(anuncio);
            _anuncioApp.Add(novoAnuncio);
            return RedirectToAction("Index");
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
