using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDDD.Application.Interfaces;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.Domain.Interfaces.Services;

namespace CatalogoDDD.Application
{
    public class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaAppService
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaAppService(ICategoriaService categoriaService) : base(categoriaService)
        {
            _categoriaService = categoriaService;
        }
    }
}
