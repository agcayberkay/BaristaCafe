using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.ViewComponents.LayoutViewComponents
{
    public class _LayoutSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
