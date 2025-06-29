using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.LocaitonCommands
{
    public class CreateLocationCommand:IRequest
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
