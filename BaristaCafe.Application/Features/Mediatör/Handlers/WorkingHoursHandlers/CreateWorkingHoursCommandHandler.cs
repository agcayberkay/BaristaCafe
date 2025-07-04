using BaristaCafe.Application.Features.Mediatör.Commands.WorkingHoursCommands;
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
    public class CreateWorkingHoursCommandHandler : IRequestHandler<CreateWorkingHoursCommand>
    {
        private readonly IRepository<WorkingHours> _repository;

        public CreateWorkingHoursCommandHandler(IRepository<WorkingHours> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateWorkingHoursCommand request, CancellationToken cancellationToken)
        {
           await _repository.CrateAsync(new WorkingHours
           {
               ClosedDay = request.ClosedDay,
               HolidaysWorkClock = request.HolidaysWorkClock,
               ClosingTime = request.ClosingTime,
               HolidaysWorkTime = request.HolidaysWorkTime,
               OpeningTime = request.OpeningTime,
               WorkingDays = request.WorkingDays             
           });
        }
    }
}
