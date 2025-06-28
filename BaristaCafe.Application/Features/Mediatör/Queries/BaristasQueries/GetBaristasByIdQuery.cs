using BaristaCafe.Application.Features.Mediatör.Results.BaristasResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Queries.BaristasQueries
{
    public class GetBaristasByIdQuery:IRequest<GetBaristasByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBaristasByIdQuery(int id)
        {
            Id = id;
        }
    }
}
