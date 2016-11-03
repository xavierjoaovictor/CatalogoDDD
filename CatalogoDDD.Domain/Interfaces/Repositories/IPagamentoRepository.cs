using System.Collections.Generic;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Domain.Interfaces.Repositories
{
    public interface IPagamentoRepository : IRepositoryBase<Pagamento>
    {
        IEnumerable<Pagamento> BuscarPorAnuncio(Anuncio anuncio);
    }
}
