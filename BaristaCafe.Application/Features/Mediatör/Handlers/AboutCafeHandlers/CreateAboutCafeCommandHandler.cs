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
    public class CreateAboutCafeCommandHandler : IRequestHandler<CreateAboutCafeCommand>
    {
        private readonly IRepository<AboutCafe> _repository;

        public CreateAboutCafeCommandHandler(IRepository<AboutCafe> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutCafeCommand request, 
            CancellationToken cancellationToken)
        {
          await _repository.CrateAsync(new AboutCafe
          {
              CafeName = request.CafeName,
              Desc = request.Desc,
              Title = request.Title,
              VideoUrl = request.VideoUrl

          });
        }
    }
}
