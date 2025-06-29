using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.TestimonialCommands
{
    public class RemoveTestimonialCommand:IRequest
    {
        public int Id { get; set; }
        public RemoveTestimonialCommand(int id)
        {
            Id = id;
        }
    }
}
