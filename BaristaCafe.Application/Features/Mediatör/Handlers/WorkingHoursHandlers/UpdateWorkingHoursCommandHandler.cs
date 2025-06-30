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
    public class UpdateWorkingHoursCommandHandler : IRequestHandler<UpdateWorkingHoursCommand>
    {
        private readonly IRepository<WorkingHours> _repository;

        public UpdateWorkingHoursCommandHandler(IRepository<WorkingHours> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateWorkingHoursCommand request, CancellationToken cancellationToken)
        {
            var workingHours = await _repository.GetByIdAsync(request.WorkingHoursId);
            workingHours.WorkingDays = request.WorkingDays;
            workingHours.ClosedDay = request.ClosedDay;
            workingHours.ClosingTime = request.ClosingTime;
            workingHours.OpeningTime = request.OpeningTime;
            workingHours.HolidaysWorkTime = request.HolidaysWorkTime;
            await _repository.UpdateAsync(workingHours);
        }
    }
}
