using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        
        public int ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
         
        public string Imagem { get; set; }
        
        //Foreing Key
        public int CategoriaId { get; set; }
         
        public virtual CategoriaViewModel Categoria { get; set; }

        public virtual ICollection<PagamentoViewModel> Pagamentos { get; set; }

    }
}