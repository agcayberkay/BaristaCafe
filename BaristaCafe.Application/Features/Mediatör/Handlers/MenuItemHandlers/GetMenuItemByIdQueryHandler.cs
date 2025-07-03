using BaristaCafe.Application.Features.Mediatör.Queries.MenuItemQueries;
using BaristaCafe.Application.Features.Mediatör.Queries.MenuQueries;
using BaristaCafe.Application.Features.Mediatör.Results.MenuItem;
using BaristaCafe.Application.Features.Mediatör.Results.MenuResults;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.MenuItemHandlers
{
    public class GetMenuItemByIdQueryHandler:IRequestHandler<GetMenuItemByIdQuery, GetMenuItemByIdQueryResult>
    {
        private readonly IRepository<MenuItem> _repository;

        public GetMenuItemByIdQueryHandler(IRepository<MenuItem> repository)
        {
            _repository = repository;
        }

        public async Task<GetMenuItemByIdQueryResult> Handle(GetMenuItemByIdQuery request, CancellationToken cancellationToken)
        {
            var menu = await _repository.GetByIdAsync(request.Id);
            return new GetMenuItemByIdQueryResult
            {
                Id = menu.Id,
                Description = menu.Description,
                Name = menu.Name,
                Price = menu.Price,
                MenuId = menu.MenuId
            };
        }
    }
}
