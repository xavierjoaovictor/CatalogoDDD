using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoDDD.Domain.Entities
{
    public class Endereco
    {
        public virtual Cliente Cliente { get; set; }

        public int ClienteId { get; set; }
        
        public int CEP { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

    }
}
