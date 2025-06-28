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
    public class UpdateBaristasCommandHandler : IRequestHandler<UpdateBaristasCommand>
    {
        private readonly IRepository<Baristas> _repository;

        public UpdateBaristasCommandHandler(IRepository<Baristas> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBaristasCommand request, CancellationToken cancellationToken)
        {
            var barista = await _repository.GetByIdAsync(request.BaristasId);
            barista.BigTitle = request.BigTitle;
            barista.Desc = request.Desc;
            barista.Grade = request.Grade;
            barista.ImageUrl = request.ImageUrl;
            barista.Name = request.Name;
            barista.Title = request.Title;
            await _repository.UpdateAsync(barista);
        }
    }
}
