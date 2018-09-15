using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using StdCoreApp.Application.Interfaces;
using StdCoreApp.Application.ViewModels.System;
using StdCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StdCoreApp.Application.Implementations
{
    public class FunctionService : IFunctionService
    {
        private IFunctionRepository _functionRepository;

        public FunctionService(IFunctionRepository functionRepository)
        {
            _functionRepository = functionRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task<List<FunctionViewModel>> GetAll()
        {
            return _functionRepository.FindAll().ProjectTo<FunctionViewModel>().ToListAsync();
        }

        public List<FunctionViewModel> GetAllByPermission(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}