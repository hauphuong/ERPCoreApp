﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace StdCoreApp.Controllers.Components
{
    public class BrandViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}