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
    public class CreateCafeMenuCommandHandler : IRequestHandler<CreateCafeMenuCommand>
    {
        private readonly IRepository<CafeMenu> _repository;

        public CreateCafeMenuCommandHandler(IRepository<CafeMenu> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCafeMenuCommand request, CancellationToken cancellationToken)
        {
          await _repository.CrateAsync(new CafeMenu
          {
              Description = request.Description,
              Favorite = request.Favorite,
              MenuName = request.MenuName,
              Price = request.Price,
              ProductName = request.ProductName,
              Title = request.Title
          });
        }
    }
}
