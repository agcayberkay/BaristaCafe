using BaristaCafe.Application.Features.Mediatör.Queries.BaristasQueries;
using BaristaCafe.Application.Features.Mediatör.Results.AboutCafeResults;
using BaristaCafe.Application.Features.Mediatör.Results.BaristasResults;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.BaristasHandlers
{
    public class GetBaristasByIdQueryHandler : IRequestHandler<GetBaristasByIdQuery, GetBaristasByIdQueryResult>
    {
        private readonly IRepository<Baristas> _repository;

        public GetBaristasByIdQueryHandler(IRepository<Baristas> repository)
        {
            _repository = repository;
        }

        public async Task<GetBaristasByIdQueryResult> Handle(GetBaristasByIdQuery request, CancellationToken cancellationToken)
        {
            var barista = await _repository.GetByIdAsync(request.Id);
            return new GetBaristasByIdQueryResult
            {
                BaristasId = barista.BaristasId,
                Name = barista.Name,
                Grade = barista.Grade,
                Desc = barista.Desc,
                ImageUrl = barista.ImageUrl
            };
        }
    }
}
