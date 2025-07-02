using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.BaristaDescCommands
{
    public class RemoveBaristaDescCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveBaristaDescCommand(int id)
        {
            Id = id;
        }
    }
}
