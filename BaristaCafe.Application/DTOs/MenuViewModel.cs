using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.DTOs
{
    public class MenuViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<MenuItemViewModel> Items { get; set; }
    }
}
