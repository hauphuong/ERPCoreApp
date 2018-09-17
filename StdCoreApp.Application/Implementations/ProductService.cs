using AutoMapper.QueryableExtensions;
using StdCoreApp.Application.Interfaces;
using StdCoreApp.Application.ViewModels.Product;
using StdCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StdCoreApp.Application.Implementations
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductViewModel> GetAll()
        {
            return _productRepository.FindAll(x => x.ProductCategory).ProjectTo<ProductViewModel>().ToList();
        }
    }
}