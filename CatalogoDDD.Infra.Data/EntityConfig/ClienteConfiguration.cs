using System.Data.Entity.ModelConfiguration;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome).IsRequired().HasMaxLength(150);

            Property(c => c.Natureza).IsRequired();

        }
    }
}
