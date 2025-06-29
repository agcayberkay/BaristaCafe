using BaristaCafe.Application.Features.Mediatör.Commands.WelcomeScreenCommands;
using BaristaCafe.Application.Features.Mediatör.Queries.WelcomeScreenQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeScreensController : ControllerBase
    {

        private readonly IMediator _mediator;

        public WelcomeScreensController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetWelcomeScreens()
        {
            var value = await _mediator.Send(new GetWelcomeScreenQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWelcomeScreens(CreateWelcomeScreenCommand command)
        {
            await _mediator.Send(command);
            return Ok("Giriş Ekranı Bilgisi başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWelcomeScreens(UpdateWelcomeScreenCommand command)
        {
            await _mediator.Send(command);
            return Ok("Giriş Ekranı Bilgisi başarıyla güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteWelcomeScreens(int id)
        {
            await _mediator.Send(new RemoveWelcomeScreenCommand(id));
            return Ok("Giriş Ekranı Bilgisi başarıyla silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWelcomeScreensById(int id)
        {
            var result = await _mediator.Send(new GetWelcomeScreenByIdQuery(id));
            return Ok(result);
        }
    }
}
