using StdCoreApp.Data.Entities;
using StdCoreApp.Data.IRepositories;

namespace StdCoreApp.Data.EF.Repositories
{
    public class BillDetailRepository : EFRepository<BillDetail, int>, IBillDetailRepository
    {
        public BillDetailRepository(AppDbContext context) : base(context)
        {
        }
    }
}