using BaristaCafe.Application.Features.Mediatör.Queries.MenuQueries;
using BaristaCafe.Application.Features.Mediatör.Results.MenuResults;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.MenuHandlers
{
    public class GetMenuQueryHandler : IRequestHandler<GetMenuQuery, List<GetMenuQueryResult>>
    {
        private readonly IRepository<Menu> _repository;

        public GetMenuQueryHandler(IRepository<Menu> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetMenuQueryResult>> Handle(GetMenuQuery request, CancellationToken cancellationToken)
        {
           var menus = await _repository.GetAllAsync();
            return menus.Select(menu => new GetMenuQueryResult
            {
               Id = menu.Id,
                Title = menu.Title
            }).ToList();
        }
    }
}
