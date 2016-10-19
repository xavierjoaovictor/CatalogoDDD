using CatalogoDDD.Domain.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CatalogoDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome!")]
        [MaxLength(150, ErrorMessage = "Maximo de {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Minimo de {0} caracteres")]
        public string Nome { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public NaturezaClienteEnum Natureza { get; set; }

        public virtual IEnumerable<AnuncioViewModel> Anuncios { get; set; }

    }
}