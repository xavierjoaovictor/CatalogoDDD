using CatalogoDDD.Domain.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CatalogoDDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string NomeFantasaia { get; set; }

        public DateTime DataCadastro  { get; set; }

        public DateTime DataNascimento { get; set; }

        public string RazaoSocial { get; set; }

        public string Cpf { get; set; }

        public string Cnpj { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public int Telefone { get; set; }

        public virtual IEnumerable<Anuncio> Anuncios { get; set; }

        public virtual Endereco Endereco { get; set; }
        
        public bool ClienteVIP(Cliente cliente)
        {
            return cliente.Anuncios.Any(c => c.ValorPago > 0);
        }
    }
}
