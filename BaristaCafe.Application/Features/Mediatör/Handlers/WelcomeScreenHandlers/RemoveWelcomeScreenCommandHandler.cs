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
    public class RemoveWelcomeScreenCommandHandler : IRequestHandler<RemoveWelcomeScreenCommand>
    {
        private readonly IRepository<WelcomeScreen> _repository;

        public RemoveWelcomeScreenCommandHandler(IRepository<WelcomeScreen> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveWelcomeScreenCommand request, CancellationToken cancellationToken)
        {
            var welcomeScreen = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(welcomeScreen);
        }
    }
}
