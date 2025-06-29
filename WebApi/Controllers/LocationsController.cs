using BaristaCafe.Application.Features.Mediatör.Commands.LocaitonCommands;
using BaristaCafe.Application.Features.Mediatör.Queries.LocationQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetLocations()
        {
            var value = await _mediator.Send(new GetLocationQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLocations(CreateLocationCommand command)
        {
            await _mediator.Send(command);
            return Ok("Lokasyon Bilgisi başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLocations(UpdateLocationCommand command)
        {
            await _mediator.Send(command);
            return Ok("Lokasyon Bilgisi başarıyla güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteLocations(int id)
        {
            await _mediator.Send(new RemoveLocationCommand(id));
            return Ok("Lokasyon Bilgisi başarıyla silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocationsById(int id)
        {
            var result = await _mediator.Send(new GetLocationByIdQuery(id));
            return Ok(result);
        }
    }
}
