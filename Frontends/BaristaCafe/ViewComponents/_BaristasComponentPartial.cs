using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _BaristasComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
