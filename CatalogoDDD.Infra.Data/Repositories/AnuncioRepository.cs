using System;
using System.Collections.Generic;
using System.Linq;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.Domain.Interfaces.Repositories;

namespace CatalogoDDD.Infra.Data.Repositories
{
    public class AnuncioRepository : RepositoryBase<Anuncio>, IAnuncioRepository
    {
        public IEnumerable<Anuncio> BuscarPorCliente(Cliente cliente)
        {
            return Db.Anuncios.Where(a => a.ClienteId == cliente.ClienteId);
        }
    }
}
