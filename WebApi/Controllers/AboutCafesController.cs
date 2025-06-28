using BaristaCafe.Application.Features.Mediatör.Commands.AboutCafe;
using BaristaCafe.Application.Features.Mediatör.Queries.AboutCafeQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutCafesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutCafesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAboutCafes()
        {
            var value = await _mediator.Send(new GetAboutCafeQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutCafe(CreateAboutCafeCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hakkımda Bilgisi başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAboutCafe(UpdateAboutCafeCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hakkımda Bilgisi başarıyla güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAboutCafe(int id)
        {
            await _mediator.Send(new RemoveAboutCafeCommand(id));
            return Ok("Hakkımda Bilgisi başarıyla silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutCafeById(int id)
        {
            var result = await _mediator.Send(new GetAboutCafeByIdQuery(id));
            return Ok(result);
        }
    }
}
