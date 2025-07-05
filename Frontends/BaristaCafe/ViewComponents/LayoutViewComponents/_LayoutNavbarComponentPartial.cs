
using Microsoft.AspNetCore.Mvc;


namespace MyPortfolyo.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
