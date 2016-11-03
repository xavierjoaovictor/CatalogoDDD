using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using CatalogoDDD.Application.Interfaces;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.MVC.ViewModels;

namespace CatalogoDDD.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteApp;
        private readonly IAnuncioAppService _anuncioApp;

        public ClientesController(IClienteAppService clienteApp, IAnuncioAppService anuncioApp)
        {
            _anuncioApp = anuncioApp;
            _clienteApp = clienteApp;
        }

        #region [ Index ]
        // GET: Clientes
        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.GetAll());
            return View(clienteViewModel);
        }
        #endregion

        #region [ Login ]
        //GET
        public ActionResult Login()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) return RedirectToAction("Login");
            var cliente =
                _clienteApp
                    .GetAll()
                    .FirstOrDefault(c => c.Email.Equals(loginViewModel.Email) && c.Senha.Equals(loginViewModel.Senha));

            if (cliente == null) return RedirectToAction("Login");
            Session["usuarioLogadoId"] = cliente.ClienteId.ToString();
            return RedirectToAction("Index", "Anuncios");
        }
        #endregion
        
        #region [ Details ]
        public ActionResult Details(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var anuncios = _anuncioApp.BuscarPorCliente(cliente);
            cliente.Anuncios = anuncios;

            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }
        #endregion

        #region [ Create ]
        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }
        
        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (!ModelState.IsValid) return View(cliente);

            var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
            _clienteApp.Add(clienteDomain);
            return RedirectToAction("Details", clienteDomain.ClienteId);
        }
        #endregion

        #region [ Edit ]
        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel cliente)
        {
            if (!ModelState.IsValid) return View(cliente);

            var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
            _clienteApp.Update(clienteDomain);
            return RedirectToAction("Index");
        }
        #endregion

        #region [ Delete ]
        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = _clienteApp.GetById(id);
            _clienteApp.Remove(cliente);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
