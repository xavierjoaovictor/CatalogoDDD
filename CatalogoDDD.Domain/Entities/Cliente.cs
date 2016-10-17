using CatalogoDDD.Domain.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CatalogoDDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro  { get; set; }
        public NaturezaClienteEnum Natureza { get; set; }
        
        public virtual IEnumerable<Anuncio> Anuncios { get; set; }

        public bool ClienteVIP(Cliente cliente)
        {
            return cliente.Anuncios.Any(c => c.ValorPago > 0);
        }
    }
}
