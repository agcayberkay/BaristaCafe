using BaristaCafe.Application.Features.Mediatör.Results.WorkingDaysResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Queries.WorkingHoursQueries
{
    public class GetWorkingHoursQuery:IRequest<List<GetWorkingHoursQueryResult>>
    {

    }
}
