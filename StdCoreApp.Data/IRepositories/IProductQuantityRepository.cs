using StdCoreApp.Data.Entities;
using StdCoreApp.Infrastruture.Interfaces;

namespace StdCoreApp.Data.IRepositories
{
    public interface IProductQuantityRepository : IRepository<ProductQuantity, int>
    {
    }
}