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
    public class GetWorkingHoursQueryHandler : IRequestHandler<GetWorkingHoursQuery, List<GetWorkingHoursQueryResult>>
    {
        private readonly IRepository<WorkingHours> _repository;

        public GetWorkingHoursQueryHandler(IRepository<WorkingHours> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetWorkingHoursQueryResult>> Handle(GetWorkingHoursQuery request, 
            CancellationToken cancellationToken)
        {
            var workingHours = await _repository.GetAllAsync();
            return workingHours.Select(wh => new GetWorkingHoursQueryResult
            {
                ClosedDay = wh.ClosedDay,
                HolidaysWorkClock = wh.HolidaysWorkClock,
                ClosingTime = wh.ClosingTime,
                HolidaysWorkTime = wh.HolidaysWorkTime,
                OpeningTime = wh.OpeningTime,
                WorkingDays = wh.WorkingDays,
                WorkingHoursId = wh.WorkingHoursId
            }).ToList();
        }
    }
}
