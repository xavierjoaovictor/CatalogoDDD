using System.Data.Entity.ModelConfiguration;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Infra.Data.EntityConfig
{
    public class AnuncioConfiguration : EntityTypeConfiguration<Anuncio>
    {
        public AnuncioConfiguration()
        {
            HasKey(a => a.AnuncioId);

            Property(a => a.Descricao).IsRequired();

            HasRequired(a => a.Cliente)
                .WithMany()
                .HasForeignKey(a => a.ClienteId);
        }
    }
}
