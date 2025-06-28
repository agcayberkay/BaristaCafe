using BaristaCafe.Application.Features.Mediatör.Queries.BaristasQueries;
using BaristaCafe.Application.Features.Mediatör.Results.BaristasCafeResults;
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
    public class GetBaristasQueryHandler : IRequestHandler<GetBaristasQuery, List<GetBaristasQueryResult>>
    {
        private readonly IRepository<Baristas> _repository;

        public GetBaristasQueryHandler(IRepository<Baristas> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBaristasQueryResult>> Handle(GetBaristasQuery request, CancellationToken cancellationToken)
        {
            var baristas = await _repository.GetAllAsync();
            return baristas.Select(b => new GetBaristasQueryResult
            {
                BigTitle = b.BigTitle,
                Desc = b.Desc,
                Grade = b.Grade,
                ImageUrl = b.ImageUrl,
                Name = b.Name,
                Title = b.Title
            }).ToList();
        }
    }
}
