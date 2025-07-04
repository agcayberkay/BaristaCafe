using BaristaCafe.Application.Features.Mediatör.Queries.TestimonialQueries;
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
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
           var testimonials = await _repository.GetAllAsync();
            return testimonials.Select(t => new GetTestimonialQueryResult
            {
                Desc = t.Desc,
                ImageUrl = t.ImageUrl,
                Grade = t.Grade,
                Name = t.Name,
                Rating = t.Rating,
                TestimonialId = t.TestimonialId,

            }).ToList();
        }
    }
}
