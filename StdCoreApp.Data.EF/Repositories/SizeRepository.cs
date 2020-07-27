using StdCoreApp.Data.Entities;
using StdCoreApp.Data.IRepositories;

namespace StdCoreApp.Data.EF.Repositories
{
    public class SizeRepository : EFRepository<Size, int>, ISizeRepository
    {
        public SizeRepository(AppDbContext context) : base(context)
        {
        }
    }
}