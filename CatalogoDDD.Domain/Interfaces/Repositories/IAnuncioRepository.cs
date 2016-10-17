using System.Collections.Generic;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Domain.Interfaces.Repositories
{
    public interface IAnuncioRepository : IRepositoryBase<Anuncio>
    {
        IEnumerable<Anuncio> BuscarPorCliente(Cliente cliente);
    }
}
