using BaristaCafe.Application.Features.Mediatör.Results.BaristaDescResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Queries.BaristaDescQueries
{
    public class GetBaristaDescByIdQuery : IRequest<GetBaristaDescByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBaristaDescByIdQuery(int id)
        {
            Id = id;
        }
    }
}
