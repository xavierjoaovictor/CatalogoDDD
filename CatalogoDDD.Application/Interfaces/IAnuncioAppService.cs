using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Application.Interfaces
{
    public interface IAnuncioAppService : IAppServiceBase<Anuncio>
    {
        IEnumerable<Anuncio> BuscarPorCliente(Cliente cliente);
    }
}
