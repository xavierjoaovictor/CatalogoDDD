﻿using System.Collections.Generic;
using CatalogoDDD.Domain.Entities;

namespace CatalogoDDD.Application.Interfaces
{
    public interface IAnuncioAppService : IAppServiceBase<Anuncio>
    {
        IEnumerable<Anuncio> BuscarPorCliente(Cliente cliente);
    }
}
