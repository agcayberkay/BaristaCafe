using BaristaCafe.Application.Features.Mediatör.Queries.AboutCafeQueries;
using BaristaCafe.Application.Features.Mediatör.Results.AboutCafeResults;
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
    public class GetAboutCafeQueryHandler : IRequestHandler<GetAboutCafeQuery, List<GetAboutCafeQueryResult>>
    {
        private readonly IRepository<AboutCafe> _repository;

        public GetAboutCafeQueryHandler(IRepository<AboutCafe> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAboutCafeQueryResult>> Handle(GetAboutCafeQuery request,
            CancellationToken cancellationToken)
        {         
            var values = await _repository.GetAllAsync();
            return values.Select(ac => new GetAboutCafeQueryResult
            {
                AboutCafeId = ac.AboutCafeId,
                CafeName = ac.CafeName,
                Title = ac.Title,
                Desc = ac.Desc,
                VideoUrl = ac.VideoUrl
            }).ToList();
        }
    }
}
