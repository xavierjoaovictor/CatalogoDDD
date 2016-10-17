using System;
using System.Collections.Generic;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Domain.Interfaces.Services
{
    public interface IAnuncioService : IServiceBase<Anuncio>
    {
        IEnumerable<Anuncio> BuscarPorCliente(Cliente cliente);
    }
}
