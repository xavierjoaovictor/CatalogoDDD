using System.Collections.Generic;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Application.Interfaces
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesVIPs();
    }
}
