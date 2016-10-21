using System.Data.Entity.ModelConfiguration;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Infra.Data.EntityConfig
{
    public class AnuncioConfiguration : EntityTypeConfiguration<Anuncio>
    {
        public AnuncioConfiguration()
        {
            HasKey(anuncio => anuncio.AnuncioId);
            
            HasRequired(a => a.Cliente)
                .WithMany()
                .HasForeignKey(a => a.ClienteId);

            HasRequired(a => a.Categoria)
                .WithMany()
                .HasForeignKey(a => a.CategoriaId);

        }
    }
}
