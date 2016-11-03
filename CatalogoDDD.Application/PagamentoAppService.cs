using System.Collections.Generic;
using CatalogoDDD.Application.Interfaces;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.Domain.Interfaces.Services;

namespace CatalogoDDD.Application
{
    public class PagamentoAppService : AppServiceBase<Pagamento>, IPagamentoAppService
    {
        private readonly IPagamentoService _pagamentoService;

        public PagamentoAppService(IPagamentoService pagamentoService) : base(pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }

        public IEnumerable<Pagamento> BuscarPorAnuncio(Anuncio anuncio)
        {
            return _pagamentoService.BuscarPorAnuncio(anuncio);
        }
    }
}
