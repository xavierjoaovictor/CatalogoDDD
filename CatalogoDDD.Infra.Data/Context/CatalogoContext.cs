using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.Infra.Data.EntityConfig;

namespace CatalogoDDD.Infra.Data.Context
{
    public class CatalogoContext : DbContext
    {
        public CatalogoContext() : base("CatalogoDB")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Anuncio> Anuncios
        {
            get;
            set;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//Produtos -> Produtoes
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(a => a.Name == a.ReflectedType.Name + "Id")
                .Configure(a => a.IsKey());

            modelBuilder.Properties<string>()
                .Configure(a => a.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(a => a.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new AnuncioConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }

        public System.Data.Entity.DbSet<CatalogoDDD.MVC.ViewModels.AnuncioViewModel> AnuncioViewModels { get; set; }

        public System.Data.Entity.DbSet<CatalogoDDD.MVC.ViewModels.ClienteViewModel> ClienteViewModels { get; set; }
    }
}
