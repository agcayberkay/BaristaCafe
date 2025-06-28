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
    public class GetAboutCafeByIdQueryHandler : IRequestHandler<GetAboutCafeByIdQuery, GetAboutCafeByIdQueryResult>
    {
        private readonly IRepository<AboutCafe> _repository;

        public GetAboutCafeByIdQueryHandler(IRepository<AboutCafe> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutCafeByIdQueryResult> Handle(GetAboutCafeByIdQuery request,
            CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetAboutCafeByIdQueryResult
            {
                AboutCafeId = values.AboutCafeId,
                CafeName = values.CafeName,
                Title = values.Title,
                Desc = values.Desc,
                VideoUrl = values.VideoUrl
            };
        }

    }
}
