using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.AboutCafe
{
    public class RemoveAboutCafeCommand:IRequest
    {
        public int Id { get; set; }
        public RemoveAboutCafeCommand(int id)
        {
            Id = id;
        }
    }
}
