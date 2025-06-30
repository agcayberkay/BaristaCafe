using BaristaCafe.Application.Features.Mediatör.Queries.WorkingHoursQueries;
using BaristaCafe.Application.Features.Mediatör.Results.WorkingDaysResults;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.WorkingHoursHandlers
{
    public class GetWorkingHoursByIdQueryHandler : IRequestHandler<GetWorkingHoursByIdQuery, GetWorkingHoursByIdQueryResult>
    {
        private readonly IRepository<WorkingHours> _repository;

        public GetWorkingHoursByIdQueryHandler(IRepository<WorkingHours> repository)
        {
            _repository = repository;
        }

        public async Task<GetWorkingHoursByIdQueryResult> Handle(GetWorkingHoursByIdQuery request, 
            CancellationToken cancellationToken)
        {
            var workingHours = await _repository.GetByIdAsync(request.Id);
            return new GetWorkingHoursByIdQueryResult
            {
                WorkingHoursId = workingHours.WorkingHoursId,
                WorkingDays = workingHours.WorkingDays,
                OpeningTime = workingHours.OpeningTime,
                ClosingTime = workingHours.ClosingTime,
                HolidaysWorkTime = workingHours.HolidaysWorkTime,
                ClosedDay = workingHours.ClosedDay
            };

        }
    }
}
