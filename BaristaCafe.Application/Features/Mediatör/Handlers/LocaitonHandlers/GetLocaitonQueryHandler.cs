using BaristaCafe.Application.Features.Mediatör.Queries.ContactQueries;
using BaristaCafe.Application.Features.Mediatör.Queries.LocationQueries;
using BaristaCafe.Application.Features.Mediatör.Results.ContactResults;
using BaristaCafe.Application.Features.Mediatör.Results.LocationResults;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.LocaitonHandlers
{
    public class GetLocaitonQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
        private readonly IRepository<Location> _repository;

        public GetLocaitonQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var locations = await _repository.GetAllAsync();
            return locations.Select(l => new GetLocationQueryResult
            {
                LocationId = l.LocationId,
                Address = l.Address,
                Email = l.Email,
                Phone = l.Phone
            }).ToList();
        }
    }
}
