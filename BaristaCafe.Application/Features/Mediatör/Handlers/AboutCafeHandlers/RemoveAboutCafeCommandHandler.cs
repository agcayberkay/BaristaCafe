using BaristaCafe.Application.Features.Mediatör.Commands.AboutCafe;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.AboutCafeHandlers
{
    public class RemoveAboutCafeCommandHandler : IRequestHandler<RemoveAboutCafeCommand>
    {
        private readonly IRepository<AboutCafe> _repository;

        public RemoveAboutCafeCommandHandler(IRepository<AboutCafe> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAboutCafeCommand request, 
            CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
