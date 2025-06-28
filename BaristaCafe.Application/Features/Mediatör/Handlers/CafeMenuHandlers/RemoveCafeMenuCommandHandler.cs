using BaristaCafe.Application.Features.Mediatör.Commands.CafeMenuCommands;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.CafeMenuHandlers
{
    public class RemoveCafeMenuCommandHandler : IRequestHandler<RemoveCafeMenuCommand>
    {
        private readonly IRepository<CafeMenu> _repository;

        public RemoveCafeMenuCommandHandler(IRepository<CafeMenu> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCafeMenuCommand request, CancellationToken cancellationToken)
        {
            var cafeMenu = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(cafeMenu);
        }
    }
}
