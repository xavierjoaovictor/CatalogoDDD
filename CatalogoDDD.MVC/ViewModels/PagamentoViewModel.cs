using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CatalogoDDD.Domain.Util;

namespace CatalogoDDD.MVC.ViewModels
{
    public class PagamentoViewModel
    {
        [Key]
        //Primary Key
        public int PagamentoId { get; set; }

        public decimal Valor { get; set; }
         
        public TipoAnuncio TipoAnuncio { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataPagamento { get; set; }

        //Relationship
        public virtual int AnuncioId { get; set; }

        //Existing only on ViewModel
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataExpiracao
        {
            get
            {
                return DataExpiracao = DataPagamento.AddDays((int)TipoAnuncio);
            } 
            set {}
        }

    }
}