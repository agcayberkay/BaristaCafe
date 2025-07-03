using BaristaCafe.Application.Features.Mediatör.Commands.MenuCommands;
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
    public class CreateMenuItemCommandHandler:IRequestHandler<CreateMenuItemCommand>
    {
        private readonly IRepository<MenuItem> _repository;

        public CreateMenuItemCommandHandler(IRepository<MenuItem> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateMenuItemCommand request, CancellationToken cancellationToken)
        {
            var menu = await _repository.GetByIdAsync(request.MenuId);
            if (menu == null)
            {
                throw new ArgumentException($"Belirtilen Menu ID {request.MenuId} bulunamadı.");
            }
            else
            {
                await _repository.CrateAsync(new MenuItem
                {
                    Description = request.Description,
                    Name = request.Name,
                    Price = request.Price,
                    MenuId = request.MenuId
                });
            }
              
        }
    }
}
