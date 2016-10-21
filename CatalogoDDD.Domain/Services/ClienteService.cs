using System.Collections.Generic;
using System.Linq;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.Domain.Interfaces.Repositories;
using CatalogoDDD.Domain.Interfaces.Services;

namespace CatalogoDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

//        public IEnumerable<Cliente> ObterClientesVIPs(IEnumerable<Cliente> clientes)
//        {
//            var clientesVips = Enumerable.Empty<Cliente>();
//            clientesVips = clientes.Where(c => c.ClienteVIP(c));
//
//            return clientesVips.Any() ? clientesVips : null;
//        }
    }
}
