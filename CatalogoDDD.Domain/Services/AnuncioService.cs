using System.Collections.Generic;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.Domain.Interfaces.Repositories;
using CatalogoDDD.Domain.Interfaces.Services;

namespace CatalogoDDD.Domain.Services
{
    public class AnuncioService : ServiceBase<Anuncio>, IAnuncioService
    {
        private readonly IAnuncioRepository _anuncioRepository;

        public AnuncioService(IAnuncioRepository anuncioRepository) : base (anuncioRepository)
        {
            _anuncioRepository = anuncioRepository;
        }

        public IEnumerable<Anuncio> BuscarPorCliente(Cliente cliente)
        {
            return _anuncioRepository.BuscarPorCliente(cliente);
        }
        
    }
}
