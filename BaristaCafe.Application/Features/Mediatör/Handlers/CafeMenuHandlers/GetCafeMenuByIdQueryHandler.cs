using BaristaCafe.Application.Features.Mediatör.Queries.CafeMenuQueries;
using BaristaCafe.Application.Features.Mediatör.Results.AboutCafeResults;
using BaristaCafe.Application.Features.Mediatör.Results.CafeMenuResluts;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.CafeMenuHandlers
{
    public class GetCafeMenuByIdQueryHandler : IRequestHandler<GetCafeMenuByIdQuery, GetCafeMenuByIdQueryResult>
    {
        private readonly IRepository<CafeMenu> _repository;

        public GetCafeMenuByIdQueryHandler(IRepository<CafeMenu> repository)
        {
            _repository = repository;
        }

        public async Task<GetCafeMenuByIdQueryResult> Handle(GetCafeMenuByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetCafeMenuByIdQueryResult
            {
                Description = values.Description,
                Price = values.Price,
                MenuName = values.MenuName,
                Favorite = values.Favorite,
                ProductName = values.ProductName,
                Title = values.Title

            };

        }
    }
}
