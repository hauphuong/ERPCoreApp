using StdCoreApp.Data.Entities;
using StdCoreApp.Data.IRepositories;

namespace StdCoreApp.Data.EF.Repositories
{
    public class ColorRepository : EFRepository<Color, int>, IColorRepository
    {
        public ColorRepository(AppDbContext context) : base(context)
        {
        }
    }
}