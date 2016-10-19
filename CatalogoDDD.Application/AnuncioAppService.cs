using System.Collections.Generic;
using CatalogoDDD.Application.Interfaces;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.Domain.Interfaces.Services;

namespace CatalogoDDD.Application
{
    public class AnuncioAppService : AppServiceBase<Anuncio>, IAnuncioAppService
    {
        private readonly IAnuncioService _anuncioService;

        public AnuncioAppService(IAnuncioService anuncioService) : base(anuncioService)
        {
            _anuncioService = anuncioService;
        }

        public IEnumerable<Anuncio> BuscarPorCliente(Cliente cliente)
        {
            return _anuncioService.BuscarPorCliente(cliente);
        }
    }
}
