using Microsoft.AspNetCore.Mvc;
using StdCoreApp.Application.Dapper.Interfaces;
using StdCoreApp.Extensions;
using System.Threading.Tasks;

namespace StdCoreApp.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IReportService _reportService;

        public HomeController(IReportService reportService)
        {
            _reportService = reportService;
        }

        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("Email");
            return View();
        }

        public async Task<IActionResult> GetRevenue(string fromDate, string toDate)
        {
            return new OkObjectResult(await _reportService.GetReportAsync(fromDate, toDate));
        }
    }
}