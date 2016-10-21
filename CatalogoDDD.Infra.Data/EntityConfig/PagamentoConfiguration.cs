using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Infra.Data.EntityConfig
{
    public class PagamentoConfiguration : EntityTypeConfiguration<Pagamento>
    {
        public PagamentoConfiguration()
        {
            HasKey(pagamento => pagamento.PagamentoId);
            
            HasRequired(pagamento => pagamento.Anuncio)
                .WithMany(anuncio => anuncio.Pagamentos)
                .HasForeignKey(pagamento => pagamento.AnuncioId);
        }
    }
}
