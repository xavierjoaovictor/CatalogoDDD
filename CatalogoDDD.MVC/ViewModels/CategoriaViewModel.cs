using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatalogoDDD.MVC.ViewModels
{
    public class CategoriaViewModel
    {
        public virtual IEnumerable<AnuncioViewModel> Anuncio { get; set; }

        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Selecione.")]
        public string Descricao { get; set; }
    }
}