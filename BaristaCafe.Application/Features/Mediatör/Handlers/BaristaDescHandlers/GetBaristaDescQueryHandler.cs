using BaristaCafe.Application.Features.Mediatör.Queries.BaristaDescQueries;
using BaristaCafe.Application.Features.Mediatör.Results.BaristaDescResults;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.BaristaDescHandlers
{
    public class GetBaristaDescQueryHandler : IRequestHandler<GetBaristaDescQuery, List<GetBaristaDescQueryResult>>
    {
        private readonly IRepository<BaristaDesc> _repository;

        public GetBaristaDescQueryHandler(IRepository<BaristaDesc> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBaristaDescQueryResult>> Handle(GetBaristaDescQuery request, CancellationToken cancellationToken)
        {
           var baristaDescs = await _repository.GetAllAsync();
            return baristaDescs.Select(b => new GetBaristaDescQueryResult
            {
                BaristaDescId = b.BaristaDescId,
                BigTitle = b.BigTitle,
                Title=b.Title
            }).ToList();
        }
    }
}
