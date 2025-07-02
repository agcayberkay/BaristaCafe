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
    public class UpdateBaristaDescCommandHandler : IRequestHandler<UpdateBaristaDescCommand>
    {
        private readonly IRepository<BaristaDesc> _repository;

        public UpdateBaristaDescCommandHandler(IRepository<BaristaDesc> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBaristaDescCommand request, CancellationToken cancellationToken)
        {
            var baristaDesc = await _repository.GetByIdAsync(request.BaristaDescId);
            baristaDesc.Title = request.Title;
            baristaDesc.BigTitle = request.BigTitle;
            await _repository.UpdateAsync(baristaDesc);
        }
    }
}
