using AutoMapper;
using StdCoreApp.Application.ViewModels.Product;
using StdCoreApp.Application.ViewModels.System;
using StdCoreApp.Data.Entities;

namespace StdCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Function, FunctionViewModel>();
        }
    }
}