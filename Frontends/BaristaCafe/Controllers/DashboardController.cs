using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            // Sabit örnek veri
            var model = new DashboardViewModel
            {
                TotalBaristas = 15,
                TotalOrders = 2450,
                TodayOrders = 120,
                TotalProducts = 35,
                LastOrders = new List<OrderViewModel>
                {
                    new OrderViewModel{ Id=1023, ProductName="Cappuccino", Status="Hazırlanıyor" },
                    new OrderViewModel{ Id=1024, ProductName="Latte", Status="Tamamlandı" },
                    new OrderViewModel{ Id=1025, ProductName="Espresso", Status="Beklemede" },
                    new OrderViewModel{ Id=1026, ProductName="Mocha", Status="İptal Edildi" },
                    new OrderViewModel{ Id=1027, ProductName="Americano", Status="Hazırlanıyor" },
                }
            };

            return View(model);
        }
    }

    public class DashboardViewModel
    {
        public int TotalBaristas { get; set; }
        public int TotalOrders { get; set; }
        public int TodayOrders { get; set; }
        public int TotalProducts { get; set; }
        public List<OrderViewModel> LastOrders { get; set; }
    }

    public class OrderViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Status { get; set; }
    }
}

