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
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public CreateLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CrateAsync(new Location
            {
                Address = request.Address,
                Phone = request.Phone,
                Email = request.Email

            });
        }
    }
}
