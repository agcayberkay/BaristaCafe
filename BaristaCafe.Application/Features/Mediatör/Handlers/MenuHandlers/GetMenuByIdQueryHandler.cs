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
    public class GetMenuByIdQueryHandler : IRequestHandler<GetMenuByIdQuery, GetMenuByIdQueryResult>
    {
        private readonly IRepository<Menu> _repository;

        public GetMenuByIdQueryHandler(IRepository<Menu> repository)
        {
            _repository = repository;
        }

        public async Task<GetMenuByIdQueryResult> Handle(GetMenuByIdQuery request, CancellationToken cancellationToken)
        {
            var menu = await _repository.GetByIdAsync(request.Id);
            return new GetMenuByIdQueryResult
            {
                Id = menu.Id,
                Title = menu.Title              
            };
        }
    }
}
