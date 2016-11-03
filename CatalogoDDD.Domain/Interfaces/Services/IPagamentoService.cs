using System.Collections.Generic;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Domain.Interfaces.Services
{
    public interface IPagamentoService : IServiceBase<Pagamento>
    {
        IEnumerable<Pagamento> BuscarPorAnuncio(Anuncio anuncio);
    }
}
