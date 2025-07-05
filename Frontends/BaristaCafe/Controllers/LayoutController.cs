using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
