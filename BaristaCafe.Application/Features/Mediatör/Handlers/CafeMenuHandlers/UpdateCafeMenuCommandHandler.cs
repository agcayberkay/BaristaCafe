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
    public class UpdateCafeMenuCommandHandler : IRequestHandler<UpdateCafeMenuCommand>
    {
        private readonly IRepository<CafeMenu> _repository;

        public UpdateCafeMenuCommandHandler(IRepository<CafeMenu> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCafeMenuCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.CafeMenuId);
            values.Description = request.Description;
            values.Price = request.Price;
            values.Favorite = request.Favorite;
            values.ProductName = request.ProductName;
            values.MenuName = request.MenuName;
            values.Title = request.Title;
            await _repository.UpdateAsync(values);

        }
    }
}
