using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.MVC.ViewModels;

namespace CatalogoDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<AnuncioViewModel, Anuncio>();
        }
    }
}