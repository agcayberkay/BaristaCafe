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
    public class RemoveMenuCommandHandler : IRequestHandler<RemoveMenuCommand>
    {
        private readonly IRepository<Menu> _repository;

        public RemoveMenuCommandHandler(IRepository<Menu> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveMenuCommand request, CancellationToken cancellationToken)
        {
            var menu = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(menu);
        }
    }
}
