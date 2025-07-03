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
    public class UpdateMenuItemCommandHandler : IRequestHandler<UpdateMenuItemCommand>
    {
        private readonly IRepository<MenuItem> _repository;

        public UpdateMenuItemCommandHandler(IRepository<MenuItem> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateMenuItemCommand request, CancellationToken cancellationToken)
        {
            var menu = await _repository.GetByIdAsync(request.MenuId);
            if (menu == null)
            {
                throw new ArgumentException($"Belirtilen Menu ID {request.MenuId} bulunamadı.");
            }
            else
            {
                var menuItem = await _repository.GetByIdAsync(request.Id);
                menuItem.Name = request.Name;
                menuItem.Description = request.Description;
                menuItem.Price = request.Price;
                menuItem.MenuId = request.MenuId;
                await _repository.UpdateAsync(menuItem);
            }

        }
    }
}
