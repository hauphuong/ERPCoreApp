using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StdCoreApp.Application.Interfaces;

namespace StdCoreApp.WebApi.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        private IProductCategoryService _productCategoryService;

        public ProductController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(_productCategoryService.GetAll());
        }
    }
}