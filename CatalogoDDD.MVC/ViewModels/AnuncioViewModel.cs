using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatalogoDDD.MVC.ViewModels
{
    public class AnuncioViewModel
    {
        [Key]
        public int AnuncioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome!")]
        [MaxLength(150, ErrorMessage = "Maximo de {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Minimo de {0} caracteres")]
        public string Descricao { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }

        public decimal ValorPago { get; set; }

        public int ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
    }
}