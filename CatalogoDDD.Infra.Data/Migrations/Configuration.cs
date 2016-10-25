using System;
using System.Collections.Generic;
using System.Linq;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.Domain.Util;

namespace CatalogoDDD.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<Context.CatalogoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Context.CatalogoContext context)
        {
            int count = context.Clientes.Count();

            var cli = new Cliente
            {
                NomeFantasia = "Cliente Teste " + (count + 1),
                Cpf = "089.838.626-88",
                DataNascimento = DateTime.Parse("08/09/1992"),
                Email = "jxavier@avenuecode.com",
                Senha = "123456"
            };

            context.Clientes.Add(cli);
            context.SaveChanges();

            var end = new Endereco
            {
                CEP = 33400000,
                Cidade = "Lagoa Santa",
                Bairro = "Varzea",
                Logradouro = "Rua da Varzea",
                Complemento = "Casa",
                Numero = count,
                Cliente = cli
            };

            context.Enderecos.Add(end);
            context.SaveChanges();

            var cate = new Categoria { Descricao = "Categoria 1" };
            context.Categorias.Add(cate);
            context.SaveChanges();

            var anun = new Anuncio
            {
                Descricao = "Anuncio Teste " + (count + 1),
                Imagem = "Imagem " + (count + 1),
                Categoria = cate,
                Cliente = cli
            };

            context.Anuncios.Add(anun);
            context.SaveChanges();
            
            var pagamentos = new Pagamento
            {
                DataPagamento = DateTime.Now,
                TipoAnuncio = TipoAnuncio.Mensal,
                Valor = 50,
                Anuncio = anun
            };

            context.Pagamentos.Add(pagamentos);
            context.SaveChanges();

        }
    }
}
