﻿using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
