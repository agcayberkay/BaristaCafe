using BaristaCafe.Application.Features.Mediatör.Commands.MenuCommands;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.MenuHandlers
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand>
    {
        private readonly IRepository<Menu> _repository;

        public CreateMenuCommandHandler(IRepository<Menu> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            await _repository.CrateAsync(new Menu
            {
                Title = request.Title
            });
        }
    }
}
