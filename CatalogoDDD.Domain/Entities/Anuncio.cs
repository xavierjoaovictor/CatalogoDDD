using System;

namespace CatalogoDDD.Domain.Entities
{
    public class Anuncio
    {
        public virtual Cliente Cliente { get; set; }

        public virtual Categoria Categoria { get; set; }

        public int ClienteId { get; set; }

        public int CategoriaId { get; set; }


        public int AnuncioId { get; set; }

        public string Descricao { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }

        public string Imagem { get; set; }

        public decimal ValorPago { get; set; }
                
    }
}
