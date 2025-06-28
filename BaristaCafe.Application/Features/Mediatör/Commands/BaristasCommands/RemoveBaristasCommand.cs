using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.BaristasCommands
{
    public class RemoveBaristasCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveBaristasCommand(int id)
        {
            Id = id;
        }
    }
}
