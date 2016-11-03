using System.Collections.Generic;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Application.Interfaces
{
    public interface IPagamentoAppService : IAppServiceBase<Pagamento>
    {
        IEnumerable<Pagamento> BuscarPorAnuncio(Anuncio anuncio);
    }
}
