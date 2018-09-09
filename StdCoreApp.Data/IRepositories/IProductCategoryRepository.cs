using StdCoreApp.Data.Entities;
using StdCoreApp.Infrastruture.Interfaces;
using System.Collections.Generic;

namespace StdCoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}