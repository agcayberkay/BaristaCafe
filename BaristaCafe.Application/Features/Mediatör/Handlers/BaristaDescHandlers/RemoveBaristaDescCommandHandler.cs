using BaristaCafe.Application.Features.Mediatör.Commands.BaristaDescCommands;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.BaristaDescHandlers
{
    public class RemoveBaristaDescCommandHandler : IRequestHandler<RemoveBaristaDescCommand>
    {
        private readonly IRepository<BaristaDesc> _repository;

        public RemoveBaristaDescCommandHandler(IRepository<BaristaDesc> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBaristaDescCommand request, CancellationToken cancellationToken)
        {
           var baristaDesc = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(baristaDesc);
        }
    }
}
