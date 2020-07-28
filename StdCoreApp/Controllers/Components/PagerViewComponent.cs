using Microsoft.AspNetCore.Mvc;
using StdCoreApp.Utilities.Dtos;
using System.Threading.Tasks;

namespace StdCoreApp.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}