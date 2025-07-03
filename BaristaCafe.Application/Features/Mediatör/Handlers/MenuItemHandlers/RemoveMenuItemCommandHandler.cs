using BaristaCafe.Application.Features.Mediatör.Commands.MenuItemCommands;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.MenuItemHandlers
{
    public class RemoveMenuItemCommandHandler : IRequestHandler<RemoveMenuItemCommand>
    {
        private readonly IRepository<MenuItem> _repository;

        public RemoveMenuItemCommandHandler(IRepository<MenuItem> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveMenuItemCommand request, CancellationToken cancellationToken)
        {
            var menuItem = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(menuItem);

        }
    }
}
