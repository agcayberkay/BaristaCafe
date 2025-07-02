using BaristaCafe.Application.Features.Mediatör.Commands.BaristaDescCommands;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.BaristaDescHandlers
{
    public class CreateBaristaDescCommandHandler : IRequestHandler<CreateBaristaDescCommand>
    {
        private readonly IRepository <BaristaDesc> _repository;

        public CreateBaristaDescCommandHandler(IRepository<BaristaDesc> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBaristaDescCommand request, CancellationToken cancellationToken)
        {
            await _repository.CrateAsync(new BaristaDesc
            {
                Title = request.Title,
                BigTitle = request.BigTitle
            });
        }
    }
}
