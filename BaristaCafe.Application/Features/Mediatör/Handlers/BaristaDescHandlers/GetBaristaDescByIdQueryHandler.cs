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
    public class GetBaristaDescByIdQueryHandler : IRequestHandler<GetBaristaDescByIdQuery, GetBaristaDescByIdQueryResult>
    {
        private readonly IRepository<BaristaDesc> _repository;

        public GetBaristaDescByIdQueryHandler(IRepository<BaristaDesc> repository)
        {
            _repository = repository;
        }

        public async Task<GetBaristaDescByIdQueryResult> Handle(GetBaristaDescByIdQuery request, CancellationToken cancellationToken)
        {
            var baristaDesc = await _repository.GetByIdAsync(request.Id);
            return new GetBaristaDescByIdQueryResult
            {
                BaristaDescId = baristaDesc.BaristaDescId,
                BigTitle = baristaDesc.BigTitle,
                Title = baristaDesc.Title
            };
        }
    }
}
