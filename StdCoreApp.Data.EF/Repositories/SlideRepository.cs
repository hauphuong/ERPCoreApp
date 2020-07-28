using StdCoreApp.Data.Entities;
using StdCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StdCoreApp.Data.EF.Repositories
{
    public class SlideRepository : EFRepository<Slide, int>, ISlideRepository
    {
        public SlideRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
