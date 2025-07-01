using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
