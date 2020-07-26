using StdCoreApp.Data.Entities;
using StdCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StdCoreApp.Data.EF.Repositories
{
    public class PermissionRepository : EFRepository<Permission, int>, IPermissionRepository
    {
        public PermissionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
