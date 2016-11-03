using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using CatalogoDDD.Application.Interfaces;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.MVC.ViewModels;
using System.Linq;
using Microsoft.Ajax.Utilities;

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

        #region [ Index ]
        // GET: Anuncios
        public ActionResult Index()
        {
            var anuncioViewModel = Enumerable.Empty<AnuncioViewModel>();

            if (Session["usuarioLogadoId"] == null)
            {
                ViewBag.ClienteLogado = false;
                anuncioViewModel =
                    Mapper.Map<IEnumerable<Anuncio>, IEnumerable<AnuncioViewModel>>(_anuncioApp.GetAll().OrderByDescending(c => c.Pagamentos.OrderByDescending(a => a.Valor)));
            }
            else
            {
                int id = Convert.ToInt32(Session["usuarioLogadoId"].ToString());
                ViewBag.ClienteLogado = true;
                anuncioViewModel =
                    Mapper.Map<IEnumerable<Anuncio>, IEnumerable<AnuncioViewModel>>(_anuncioApp.BuscarPorCliente(_clienteApp.GetById(id)));
            }

            return View(anuncioViewModel);
        }
        #endregion

        #region [ Details ]
        // GET: Anuncios/Details/5
        public ActionResult Details(int id)
        {
            var anuncio = _anuncioApp.GetById(id);
            var anuncioViewModel = Mapper.Map<Anuncio, AnuncioViewModel>(anuncio);
            return View(anuncioViewModel);
        }
        #endregion

        #region [ Create ]
        // GET: Anuncios/Create
        public ActionResult Create()
        {
            if (Session["usuarioLogadoId"] == null)
                return RedirectToAction("Login", "Clientes");

            return View();
        }
         
        // POST: Anuncios/Create
        [HttpPost] 
        [ValidateAntiForgeryToken]
        public ActionResult Create(AnuncioViewModel anuncio)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome", anuncio.ClienteId);
                return View(anuncio);
            }

            anuncio.ClienteId = Convert.ToInt32(Session["usuarioLogadoId"].ToString());
            var novoAnuncio = Mapper.Map<AnuncioViewModel, Anuncio>(anuncio);
            _anuncioApp.Add(novoAnuncio);
            return RedirectToAction("Index");
        }
        #endregion

        #region [ Edit ]
        // GET: Anuncios/Edit/5
        public ActionResult Edit(int id)
        {
            var anuncio = _anuncioApp.GetById(id);
            var anuncioViewModel = Mapper.Map<Anuncio, AnuncioViewModel>(anuncio);
            return View(anuncioViewModel);
        }

        // POST: Anuncios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AnuncioViewModel anuncio)
        {
            if (!ModelState.IsValid)
                return View(anuncio);

            var novoAnuncio = Mapper.Map<AnuncioViewModel, Anuncio>(anuncio);
            _anuncioApp.Update(novoAnuncio);
            return View(Mapper.Map<Anuncio, AnuncioViewModel>(novoAnuncio));
        }
        #endregion

        #region [ Delete ]
        // GET: Anuncios/Delete/5
        public ActionResult Delete(int id)
        {
            var anuncio = _anuncioApp.GetById(id);
            var anuncioViewModel = Mapper.Map<Anuncio, AnuncioViewModel>(anuncio);
            return View(anuncioViewModel);
        }

        // POST: Anuncios/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _anuncioApp.Remove(_anuncioApp.GetById(id));
            return RedirectToAction("Index");
        }
        #endregion
    }
}
