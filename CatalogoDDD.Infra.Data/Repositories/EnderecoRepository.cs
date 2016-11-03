using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.Domain.Interfaces.Repositories;

namespace CatalogoDDD.Infra.Data.Repositories
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
    }
}
