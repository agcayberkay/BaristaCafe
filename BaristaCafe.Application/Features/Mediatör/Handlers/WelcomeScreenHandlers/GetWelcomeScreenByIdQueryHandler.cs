using BaristaCafe.Application.Features.Mediatör.Queries.WelcomeScreenQueries;
using BaristaCafe.Application.Features.Mediatör.Results.WelcomeScreenResults;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Handlers.WelcomeScreenHandlers
{
    public class GetWelcomeScreenByIdQueryHandler : IRequestHandler<GetWelcomeScreenByIdQuery, GetWelcomeScreenByIdQueryResult>
    {
        private readonly IRepository<WelcomeScreen> _repository;

        public GetWelcomeScreenByIdQueryHandler(IRepository<WelcomeScreen> repository)
        {
            _repository = repository;
        }

        public async Task<GetWelcomeScreenByIdQueryResult> Handle(GetWelcomeScreenByIdQuery request, CancellationToken cancellationToken)
        {
            var welcomeScreen = await _repository.GetByIdAsync(request.Id);
            return new GetWelcomeScreenByIdQueryResult
            {
                WelcomeScreenId = welcomeScreen.WelcomeScreenId,
                Desc = welcomeScreen.Desc,
                Title = welcomeScreen.Title,
                Name = welcomeScreen.Name,
            };
        }
    }
}
