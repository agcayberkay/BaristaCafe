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
    public class GetContactQueryHandler : IRequestHandler<GetContactQuery, List<GetContactQueryResult>>
    {
        private readonly IRepository<Contact> _repository;

        public GetContactQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetContactQueryResult>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            var contacts = await _repository.GetAllAsync();
            return contacts.Select(c => new GetContactQueryResult
            {
                ContactId = c.ContactId,
                Name = c.Name,
                Mail = c.Mail,
                Message = c.Message
            }).ToList();
        }
    }
}
