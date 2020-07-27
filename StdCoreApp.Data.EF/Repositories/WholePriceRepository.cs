using StdCoreApp.Data.Entities;
using StdCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StdCoreApp.Data.EF.Repositories
{
    public class WholePriceRepository : EFRepository<WholePrice, int>, IWholePriceRepository
    {
        public WholePriceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
