using BaristaCafe.Application.Features.Mediatör.Results.AboutCafeResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Queries.AboutCafeQueries
{
    public class GetAboutCafeByIdQuery:IRequest<GetAboutCafeByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAboutCafeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
