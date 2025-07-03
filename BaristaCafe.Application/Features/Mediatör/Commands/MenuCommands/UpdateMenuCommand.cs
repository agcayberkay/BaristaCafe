using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.MenuCommands
{
    public class UpdateMenuCommand:IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
