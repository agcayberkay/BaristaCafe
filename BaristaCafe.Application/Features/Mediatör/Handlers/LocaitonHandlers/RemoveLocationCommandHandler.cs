using BaristaCafe.Application.Features.Mediatör.Commands.ContactCommands;
using BaristaCafe.Application.Features.Mediatör.Commands.LocaitonCommands;
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
    public class RemoveLocationCommandHandler: IRequestHandler<RemoveLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public RemoveLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
        {
            var location = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(location);
        }
    }
}
