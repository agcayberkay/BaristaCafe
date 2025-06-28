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
    public class UpdateAboutCafeCommandHandler : IRequestHandler<UpdateAboutCafeCommand>
    {

        private readonly IRepository<AboutCafe> _repository;

        public UpdateAboutCafeCommandHandler(IRepository<AboutCafe> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutCafeCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.AboutCafeId);
            value.CafeName = request.CafeName;
            value.Title = request.Title;
            value.Desc = request.Desc;
            value.VideoUrl = request.VideoUrl;
            await _repository.UpdateAsync(value);
        }
    }
}
