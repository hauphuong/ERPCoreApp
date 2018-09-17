using Microsoft.AspNetCore.Mvc;
using StdCoreApp.Extensions;

namespace StdCoreApp.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("Email");
            return View();
        }
    }
}