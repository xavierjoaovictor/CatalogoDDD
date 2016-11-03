using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CatalogoDDD.MVC.ViewModels
{
    public class LoginViewModel
    { 
        [Required(ErrorMessage = "Informe o e-mail", AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

    }
}