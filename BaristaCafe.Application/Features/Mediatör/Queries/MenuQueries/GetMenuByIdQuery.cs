using BaristaCafe.Application.Features.Mediatör.Results.MenuResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Queries.MenuQueries
{
    public class GetMenuByIdQuery:IRequest<GetMenuByIdQueryResult>
    {
        public int Id { get; set; }

        public GetMenuByIdQuery(int id)
        {
            Id = id;
        }
    }
}
