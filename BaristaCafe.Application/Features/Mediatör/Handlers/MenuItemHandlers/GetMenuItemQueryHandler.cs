using BaristaCafe.Application.Features.Mediatör.Queries.MenuItemQueries;
using BaristaCafe.Application.Features.Mediatör.Results.MenuItem;
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
    public class GetMenuItemQueryHandler:IRequestHandler<GetMenuItemQuery, List<GetMenuItemQueryResult>>
    {
        private readonly IRepository<MenuItem> _repository;

        public GetMenuItemQueryHandler(IRepository<MenuItem> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetMenuItemQueryResult>> Handle(GetMenuItemQuery request, CancellationToken cancellationToken)
        {
            var menus = await _repository.GetAllAsync();
            return menus.Select(menu => new GetMenuItemQueryResult
            {
                Description = menu.Description,
                Id = menu.Id,
                Name = menu.Name,
                Price = menu.Price,
                MenuId = menu.MenuId

            }).ToList();
        }
    }
}
