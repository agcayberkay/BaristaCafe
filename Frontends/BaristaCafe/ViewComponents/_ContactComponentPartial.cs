using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
