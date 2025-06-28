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
    public class CreateBaristasCommandHandler : IRequestHandler<CreateBaristasCommand>
    {
        private readonly IRepository<Baristas> _repository;
        public CreateBaristasCommandHandler(IRepository<Baristas> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBaristasCommand request, 
            CancellationToken cancellationToken)
        {
            await _repository.CrateAsync(new Baristas
            {
                BigTitle = request.BigTitle,
                Desc = request.Desc,
                Grade = request.Grade,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
                Title = request.Title
            });

        }
    }
}
