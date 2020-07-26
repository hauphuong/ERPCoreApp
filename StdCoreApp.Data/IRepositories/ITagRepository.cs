using StdCoreApp.Data.Entities;
using StdCoreApp.Infrastruture.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StdCoreApp.Data.IRepositories
{
    public interface ITagRepository : IRepository<Tag, string>
    {
    }
}
