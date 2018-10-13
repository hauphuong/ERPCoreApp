using StdCoreApp.Application.ViewModels.Product;
using StdCoreApp.Utilities.Dtos;
using System;
using System.Collections.Generic;

namespace StdCoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
        PageResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
    }
}