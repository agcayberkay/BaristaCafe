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
    public class UpdateLocaitonCommandHandler:IRequestHandler<UpdateLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public UpdateLocaitonCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.LocationId);
            values.Phone = request.Phone;
            values.Address = request.Address;
            values.Email = request.Email;
            await _repository.UpdateAsync(values);

        }
    }
}
