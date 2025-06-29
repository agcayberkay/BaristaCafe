using BaristaCafe.Application.Features.Mediatör.Commands.CafeMenuCommands;
using BaristaCafe.Application.Features.Mediatör.Commands.ContactCommands;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler: IRequestHandler<CreateContactCommand>
    {
        private readonly IRepository<Contact> _repository;

        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            await _repository.CrateAsync(new Contact
            {
                Mail = request.Mail,
                Message = request.Message,
                Name = request.Name
            });
        }
    }
}
