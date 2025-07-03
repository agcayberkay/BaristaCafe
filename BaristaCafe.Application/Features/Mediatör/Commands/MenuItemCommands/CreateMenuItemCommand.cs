using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.MenuItemCommands
{
    public class CreateMenuItemCommand:IRequest
    {
        public string Name { get; set; }      // Örnek: "Cheesecake", "Espresso"
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int MenuId { get; set; }

    }
}
