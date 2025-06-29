using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.WelcomeScreenCommands
{
    public class RemoveWelcomeScreenCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveWelcomeScreenCommand(int id)
        {
            Id = id;
        }
    }
}
