using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Domain.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }  // Örnek: "Tatlılar", "Kahveler"

        // Menüdeki ürünler
        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
