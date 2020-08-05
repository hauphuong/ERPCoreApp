using Microsoft.AspNetCore.Mvc;
using StdCoreApp.Application.Interfaces;

namespace StdCoreApp.Controllers
{
    public class BlogController : Controller
    {
        private IBlogService _blogService;

        public BlogController(IBlogService BlogService)
        {
            _blogService = BlogService;
        }

        [Route("blog.html", Name = "Blog")]
        public IActionResult Index(string alias)
        {
            var Blog = _blogService.GetByAlias(alias);
            return View(Blog);
        }
    }
}