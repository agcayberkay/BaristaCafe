using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.BaristasCommands
{
    public class CreateBaristasCommand:IRequest
    {
        public string Name { get; set; }
        public string Grade { get; set; }
        public string Desc { get; set; }
        public string ImageUrl { get; set; }
    }
}
