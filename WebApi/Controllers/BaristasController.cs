
using BaristaCafe.Application.Features.Mediatör.Commands.BaristasCommands;
using BaristaCafe.Application.Features.Mediatör.Queries.BaristasQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaristasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BaristasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetBaristas()
        {
            var value = await _mediator.Send(new GetBaristasQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBaristas(CreateBaristasCommand command)
        {
            await _mediator.Send(command);
            return Ok("Barista Bilgisi başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBaristas(UpdateBaristasCommand command)
        {
            await _mediator.Send(command);
            return Ok("Barista Bilgisi başarıyla güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBaristas(int id)
        {
            await _mediator.Send(new RemoveBaristasCommand(id));
            return Ok("Barista Bilgisi başarıyla silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBaristasById(int id)
        {
            var result = await _mediator.Send(new GetBaristasByIdQuery(id));
            return Ok(result);
        }
    }
}
