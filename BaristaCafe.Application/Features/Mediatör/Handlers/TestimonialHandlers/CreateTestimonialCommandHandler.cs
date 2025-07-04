using BaristaCafe.Application.Features.Mediatör.Commands.TestimonialCommands;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;

        public CreateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
           await _repository.CrateAsync(new Testimonial
           {
               Desc = request.Desc,
               ImageUrl = request.ImageUrl,
               Grade = request.Grade,
               Name = request.Name,
               Rating = request.Rating
           });
        }
    }
}
