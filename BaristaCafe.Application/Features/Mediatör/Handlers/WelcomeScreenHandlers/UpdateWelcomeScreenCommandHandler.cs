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
    public class UpdateWelcomeScreenCommandHandler : IRequestHandler<UpdateWelcomeScreenCommand>
    {
        private readonly IRepository<WelcomeScreen> _repository;

        public UpdateWelcomeScreenCommandHandler(IRepository<WelcomeScreen> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateWelcomeScreenCommand request, CancellationToken cancellationToken)
        {
           var welcomeScreen=await _repository.GetByIdAsync(request.WelcomeScreenId);
            welcomeScreen.Title = request.Title;
            welcomeScreen.Desc = request.Desc;
            welcomeScreen.Name = request.Name;
            await _repository.UpdateAsync(welcomeScreen);
        }
    }
}
