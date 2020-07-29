using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using StdCoreApp.Application.Interfaces;
using StdCoreApp.Infrastruture.Enums;
using System;
using System.Threading.Tasks;

namespace StdCoreApp.Controllers.Components
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private IProductCategoryService _productCategoryService;
        private IMemoryCache _memoryCache;
        public CategoryMenuViewComponent(IProductCategoryService productCategoryService, IMemoryCache memoryCache)
        {
            _productCategoryService = productCategoryService;
            _memoryCache = memoryCache;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _memoryCache.GetOrCreate(CacheKeys.ProductCategories, entry => {
                entry.SlidingExpiration = TimeSpan.FromHours(2);
                return _productCategoryService.GetAll();
            });

            return View(categories);
        }
    }
}