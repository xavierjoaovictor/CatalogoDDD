using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatalogoDDD.MVC.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        public int CEP { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

    }
}