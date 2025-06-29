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
    public class GetLocaitonByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly IRepository<Location> _repository;

        public GetLocaitonByIdQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var locations = await _repository.GetByIdAsync(request.Id);
            return new GetLocationByIdQueryResult
            {
                LocationId = locations.LocationId,
                Address = locations.Address,
                Phone = locations.Phone,
                Email = locations.Email
            };
        }
    }
}
