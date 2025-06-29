using BaristaCafe.Application.Features.Mediatör.Results.WelcomeScreenResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Queries.WelcomeScreenQueries
{
    public class GetWelcomeScreenByIdQuery:IRequest<GetWelcomeScreenByIdQueryResult>
    {
        public int Id { get; set; }

        public GetWelcomeScreenByIdQuery(int id)
        {
            Id = id;
        }
    }
}
