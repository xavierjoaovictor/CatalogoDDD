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
        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        public string RazaoSocial { get; set; }

        public string Cpf { get; set; }

        public string Cnpj { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public int Telefone { get; set; }
        
        public virtual EnderecoViewModel Endereco { get; set; }

        public virtual IEnumerable<AnuncioViewModel> Anuncios { get; set; }

    }
}