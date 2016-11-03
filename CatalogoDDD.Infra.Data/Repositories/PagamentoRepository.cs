using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.Domain.Interfaces.Repositories;

namespace CatalogoDDD.Infra.Data.Repositories
{
    public class PagamentoRepository : RepositoryBase<Pagamento>, IPagamentoRepository
    {
        public IEnumerable<Pagamento> BuscarPorAnuncio(Anuncio anuncio)
        {
            return Db.Pagamentos.Where(a => a.AnuncioId == anuncio.AnuncioId);
        }
    }
}
