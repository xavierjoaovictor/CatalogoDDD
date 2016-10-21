using System;
using System.Collections.Generic;

namespace CatalogoDDD.Domain.Entities
{
    public class Anuncio
    {
        //Primary Key
        public int AnuncioId { get; set; }

        public string Descricao { get; set; }
        
        public string Imagem { get; set; }

        //Foreing Key
        public int ClienteId { get; set; }
        //Foreing Key
        public int CategoriaId { get; set; }

        #region [ Relacionamentos ]
        public virtual Cliente Cliente { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();

        #endregion
        
    }
}
