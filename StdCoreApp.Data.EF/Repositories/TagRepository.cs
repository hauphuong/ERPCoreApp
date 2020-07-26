using StdCoreApp.Data.Entities;
using StdCoreApp.Data.IRepositories;

namespace StdCoreApp.Data.EF.Repositories
{
    public class TagRepository : EFRepository<Tag, string>, ITagRepository
    {
        public TagRepository(AppDbContext context) : base(context)
        {
        }
    }
}