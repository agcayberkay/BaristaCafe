using BaristaCafe.Application.Features.Mediatör.Queries.TestimonialQueries;
using BaristaCafe.Application.Features.Mediatör.Results.LocationResults;
using BaristaCafe.Application.Features.Mediatör.Results.TestimonialResults;
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
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }


        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var testimonial = await _repository.GetByIdAsync(request.Id);
            return new GetTestimonialByIdQueryResult
            {
                Name = testimonial.Name,
                Grade = testimonial.Grade,
                Desc = testimonial.Desc,
                ImageUrl = testimonial.ImageUrl,
                Rating = testimonial.Rating,
                TestimonialId = testimonial.TestimonialId
                
            };
        }
    }
}
