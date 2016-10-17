using System;

namespace CatalogoDDD.Domain.Entities
{
    public class Anuncio
    {
        public int AnuncioId { get; set; }
        public string Descricao { get; set; }  
        public DateTime DataInicial { get; set; }  
        public DateTime DataFinal { get; set; }

        public int ClienteId { get; set; }

        public decimal ValorPago { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
