using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.MenuItemCommands
{
    public class RemoveMenuItemCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveMenuItemCommand(int id)
        {
            Id = id;
        }
    }
}
