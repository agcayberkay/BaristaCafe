using BaristaCafe.Application.Features.Mediatör.Commands.WelcomeScreenCommands;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.WelcomeScreenHandlers
{
    public class CreateWelcomeScreenCommandHandler : IRequestHandler<CreateWelcomeScreenCommand>
    {
        private readonly IRepository<WelcomeScreen> _repository;

        public CreateWelcomeScreenCommandHandler(IRepository<WelcomeScreen> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateWelcomeScreenCommand request, CancellationToken cancellationToken)
        {
            await _repository.CrateAsync(new WelcomeScreen
            {
                Title = request.Title,
                Name = request.Name,
                Desc = request.Desc
            });
        }
    }
}
