using BaristaCafe.Application.Features.Mediatör.Results.TestimonialResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
    {

    }
}
