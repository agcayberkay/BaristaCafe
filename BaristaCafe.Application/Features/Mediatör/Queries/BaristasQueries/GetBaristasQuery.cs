using BaristaCafe.Application.Features.Mediatör.Results.BaristasCafeResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Queries.BaristasQueries
{
    public class GetBaristasQuery:IRequest<List<GetBaristasQueryResult>>
    {

    }
}
