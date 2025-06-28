using BaristaCafe.Application.Features.Mediatör.Commands.BaristasCommands;
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
    public class RemoveBaristasCommandHandler : IRequestHandler<RemoveBaristasCommand>
    {
        private readonly IRepository<Baristas> _repository;

        public RemoveBaristasCommandHandler(IRepository<Baristas> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBaristasCommand request, CancellationToken cancellationToken)
        {
            var barista = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(barista);
        }
    }
}
