using BaristaCafe.Application.Features.Mediatör.Results.ContactResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Queries.ContactQueries
{
    public class GetContactQuery:IRequest<List<GetContactQueryResult>>
    {

    }
}
