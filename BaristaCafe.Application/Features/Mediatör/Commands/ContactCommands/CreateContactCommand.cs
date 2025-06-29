using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.ContactCommands
{
    public class CreateContactCommand:IRequest
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Message { get; set; }
    }
}
