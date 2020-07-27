using StdCoreApp.Data.Entities;
using StdCoreApp.Data.IRepositories;

namespace StdCoreApp.Data.EF.Repositories
{
    public class BillRepository : EFRepository<Bill, int>, IBillRepository
    {
        public BillRepository(AppDbContext context) : base(context)
        {
        }
    }
}