using System;
using AutoMapper;
using CatalogoDDD.Domain.Entities;
using CatalogoDDD.MVC.ViewModels;

namespace CatalogoDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        [Obsolete("Create a constructor and configure inside of your profile\'s constructor instead. Will be removed in 6.0")]
        protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Anuncio, AnuncioViewModel>();
        }
    }
}