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
    public class CategoriasController : Controller
    {
        private readonly ICategoriaAppService _categoriaApp;

        public CategoriasController(ICategoriaAppService categoriaApp)
        {
            _categoriaApp = categoriaApp;
        }

        #region [ Index ]
        // GET: Categorias
        public ActionResult Index()
        {   
            //Mapeia lista de retorno do tipo Categoria para Visualizacao tipo ViewModel
            var categoriaViewModel = Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaApp.GetAll());
            return View(categoriaViewModel);
        }
        #endregion

        #region [ Details ]
        // GET: Categorias/Details/5
        public ActionResult Details(int id)
        {
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(_categoriaApp.GetById(id));
            return View(categoriaViewModel);
        }
        #endregion

        #region [ Create ]
        // GET: Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaViewModel categoriaViewModel)
        {
            if (!ModelState.IsValid)
                return View(categoriaViewModel);

            var categoria = Mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);
            _categoriaApp.Add(categoria);
            return RedirectToAction("Index");
        }
        #endregion

        #region [ Edit ]
        // GET: Categorias/Edit/5
        public ActionResult Edit(int id)
        {
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(_categoriaApp.GetById(id));
            return View(categoriaViewModel);
        }

        // POST: Categorias/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriaViewModel categoriaViewModel)
        {
            if (!ModelState.IsValid)
                return View(categoriaViewModel);

            var categoria = Mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);
            _categoriaApp.Update(categoria);
            return View(Mapper.Map<Categoria, CategoriaViewModel>(categoria));
        }
        #endregion

        #region [ Delete ]
        // GET: Categorias/Delete/5
        public ActionResult Delete(int id)
        {
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(_categoriaApp.GetById(id));
            return View(categoriaViewModel);
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _categoriaApp.Remove(_categoriaApp.GetById(id));
            return RedirectToAction("Index");
        }
        #endregion
    }
}
