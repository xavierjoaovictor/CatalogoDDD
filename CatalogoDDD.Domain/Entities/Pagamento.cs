using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDDD.Domain.Util;

namespace CatalogoDDD.Domain.Entities
{
    public class Pagamento
    {
        //Primary Key
        public int PagamentoId { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataPagamento { get; set; }

        public TipoAnuncio TipoAnuncio { get; set; }

        //Foreign Key
        public int AnuncioId { get; set; }
        //Relationship
        public virtual Anuncio Anuncio { get; set; }

    }
}
