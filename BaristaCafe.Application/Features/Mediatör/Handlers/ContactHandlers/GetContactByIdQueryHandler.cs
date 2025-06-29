using BaristaCafe.Application.Features.Mediatör.Queries.ContactQueries;
using BaristaCafe.Application.Features.Mediatör.Results.ContactResults;
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
    public class GetContactByIdQueryHandler : IRequestHandler<GetContactByIdQuery, GetContactByIdQueryResult>
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var contact = await _repository.GetByIdAsync(request.Id);
            return new GetContactByIdQueryResult
            {
               
                Name = contact.Name,
                Mail = contact.Mail,
                Message = contact.Message
            };
        }
    }
}
