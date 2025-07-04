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
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;

        public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var testimonial = await _repository.GetByIdAsync(request.TestimonialId);
            testimonial.Desc = request.Desc;
            testimonial.ImageUrl = request.ImageUrl;
            testimonial.Grade = request.Grade;
            testimonial.Name = request.Name;
            testimonial.Rating = request.Rating;
            await _repository.UpdateAsync(testimonial);
        }
    }
}
