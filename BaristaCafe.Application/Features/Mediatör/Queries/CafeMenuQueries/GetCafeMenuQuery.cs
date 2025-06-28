using BaristaCafe.Application.Features.Mediatör.Results.CafeMenuResluts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Queries.CafeMenuQueries
{
    public class GetCafeMenuQuery : IRequest<List<GetCafeMenuQueryResult>>
    {

    }
}
