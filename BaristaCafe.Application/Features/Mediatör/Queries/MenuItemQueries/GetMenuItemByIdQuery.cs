using BaristaCafe.Application.Features.Mediatör.Results.MenuItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Queries.MenuItemQueries
{
    public class GetMenuItemByIdQuery:IRequest<GetMenuItemByIdQueryResult>
    {
        public int Id { get; set; }

        public GetMenuItemByIdQuery(int id)
        {
            Id = id;
        }
    }
}
