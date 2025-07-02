using BaristaCafe.Application.Features.Mediatör.Commands.BaristaDescCommands;
using BaristaCafe.Application.Features.Mediatör.Queries.BaristaDescQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaristaDescsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BaristaDescsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetBaristaDescs()
        {
            var value = await _mediator.Send(new GetBaristaDescQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBaristaDescs(CreateBaristaDescCommand command)
        {
            await _mediator.Send(command);
            return Ok("Barista Partial  Bilgisi başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBaristaDescs(UpdateBaristaDescCommand command)
        {
            await _mediator.Send(command);
            return Ok("Barista Partial  Bilgisi başarıyla güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBaristaDescs(int id)
        {
            await _mediator.Send(new RemoveBaristaDescCommand(id));
            return Ok("Barista Partial  Bilgisi başarıyla silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBaristaDescsById(int id)
        {
            var result = await _mediator.Send(new GetBaristaDescByIdQuery(id));
            return Ok(result);
        }
    }
}
