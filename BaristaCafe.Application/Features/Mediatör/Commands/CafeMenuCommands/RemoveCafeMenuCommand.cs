using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.CafeMenuCommands
{
    public class RemoveCafeMenuCommand:IRequest
    {
        public int Id { get; set; }
        public RemoveCafeMenuCommand(int id)
        {
            Id = id;
        }
    }
}
