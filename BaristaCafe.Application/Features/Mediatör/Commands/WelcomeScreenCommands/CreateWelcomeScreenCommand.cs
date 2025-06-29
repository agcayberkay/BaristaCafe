using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.WelcomeScreenCommands
{
    public class CreateWelcomeScreenCommand:IRequest
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}
