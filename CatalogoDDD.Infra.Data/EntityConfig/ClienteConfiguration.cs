using System.Data.Entity.ModelConfiguration;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            HasRequired(c => c.Endereco)
                .WithRequiredPrincipal(endereco => endereco.Cliente);
        }
    }
}
