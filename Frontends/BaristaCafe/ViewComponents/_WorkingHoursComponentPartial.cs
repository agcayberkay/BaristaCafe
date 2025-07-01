using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _WorkingHoursComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
