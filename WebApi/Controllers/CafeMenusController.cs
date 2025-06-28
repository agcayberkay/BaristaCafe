using BaristaCafe.Application.Features.Mediatör.Commands.CafeMenuCommands;
using BaristaCafe.Application.Features.Mediatör.Queries.CafeMenuQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CafeMenusController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CafeMenusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCafeMenus()
        {
            var value = await _mediator.Send(new GetCafeMenuQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCafeMenus(CreateCafeMenuCommand command)
        {
            await _mediator.Send(command);
            return Ok("Menü Bilgisi başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCafeMenus(UpdateCafeMenuCommand command)
        {
            await _mediator.Send(command);
            return Ok("Menü Bilgisi başarıyla güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCafeMenus(int id)
        {
            await _mediator.Send(new RemoveCafeMenuCommand(id));
            return Ok("Menü Bilgisi başarıyla silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCafeMenusById(int id)
        {
            var result = await _mediator.Send(new GetCafeMenuByIdQuery(id));
            return Ok(result);
        }
    }
}
