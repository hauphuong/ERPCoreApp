using Microsoft.AspNetCore.Mvc;
using StdCoreApp.Application.Interfaces;

namespace StdCoreApp.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region AJAX API

        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _productService.GetAll();
            return new OkObjectResult(model);
        }

        #endregion AJAX API
    }
}