using BaristaCafe.Application.Features.Mediatör.Queries.CafeMenuQueries;
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
    public class GetCafeMenuQueryHandler : IRequestHandler<GetCafeMenuQuery, List<GetCafeMenuQueryResult>>
    {
        private readonly IRepository<CafeMenu> _repository;

        public GetCafeMenuQueryHandler(IRepository<CafeMenu> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCafeMenuQueryResult>> Handle(GetCafeMenuQuery request, CancellationToken cancellationToken)
        {
           var values= await _repository.GetAllAsync();
            return values.Select(x => new GetCafeMenuQueryResult
            {
                CafeMenuId = x.CafeMenuId,
                Description = x.Description,
                Favorite = x.Favorite,
                MenuName = x.MenuName,
                Price = x.Price,
                ProductName = x.ProductName,
                Title = x.Title
            }).ToList();
        }
    }
}
