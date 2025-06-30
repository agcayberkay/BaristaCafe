using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.WorkingHoursCommands
{
    public class RemoveWorkingHoursCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveWorkingHoursCommand(int id)
        {
            Id = id;
        }
    }
}
