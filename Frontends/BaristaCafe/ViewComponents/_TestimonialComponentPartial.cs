using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
