using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Domain.Entities
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }      // Örnek: "Cheesecake", "Espresso"
        public decimal Price { get; set; }
        public string Description { get; set; }

        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
