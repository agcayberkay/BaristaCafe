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
    public class GetWelcomeScreenQueryHandler : IRequestHandler<GetWelcomeScreenQuery, List<GetWelcomeScreenQueryResult>>
    {
        private readonly IRepository<WelcomeScreen> _repository;

        public GetWelcomeScreenQueryHandler(IRepository<WelcomeScreen> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetWelcomeScreenQueryResult>> Handle(GetWelcomeScreenQuery request, CancellationToken cancellationToken)
        {
            var welcomeScreens = await _repository.GetAllAsync();
            return welcomeScreens.Select(ws => new GetWelcomeScreenQueryResult
            {
               Desc = ws.Desc,
                Name = ws.Name,
                Title = ws.Title,
                WelcomeScreenId = ws.WelcomeScreenId
            }).ToList();
        }
    }
}
