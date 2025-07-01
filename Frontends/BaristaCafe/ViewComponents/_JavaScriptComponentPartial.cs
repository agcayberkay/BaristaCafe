using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _JavaScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
