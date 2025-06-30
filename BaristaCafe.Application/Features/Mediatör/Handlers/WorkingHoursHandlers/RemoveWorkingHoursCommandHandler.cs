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
    public class RemoveWorkingHoursCommandHandler : IRequestHandler<RemoveWorkingHoursCommand>
    {
        private readonly IRepository<WorkingHours> _repository;

        public RemoveWorkingHoursCommandHandler(IRepository<WorkingHours> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveWorkingHoursCommand request, CancellationToken cancellationToken)
        {
            var workingHours = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(workingHours);
        }
    }
}
