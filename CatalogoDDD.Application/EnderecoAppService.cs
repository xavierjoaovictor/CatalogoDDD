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
    public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService enderecoService) : base(enderecoService)
        {
            _enderecoService = enderecoService;
        }
    }
}
