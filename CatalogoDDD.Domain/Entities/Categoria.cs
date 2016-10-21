using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoDDD.Domain.Entities
{
    public class Categoria
    {
        public virtual IEnumerable<Anuncio> Anuncio { get; set; } = new List<Anuncio>();

        public int CategoriaId { get; set; }

        public string Descricao { get; set; }
    }
}
