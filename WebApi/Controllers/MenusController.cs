using BaristaCafe.Application.Features.Mediatör.Commands.MenuCommands;
using BaristaCafe.Application.Features.Mediatör.Queries.MenuQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MenusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetMenus()
        {
            var value = await _mediator.Send(new GetMenuQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMenus(CreateMenuCommand command)
        {
            await _mediator.Send(command);
            return Ok("MenüBilgisi başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMenus(UpdateMenuCommand command)
        {
            await _mediator.Send(command);
            return Ok("MenüBilgisi başarıyla güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMenus(int id)
        {
            await _mediator.Send(new RemoveMenuCommand(id));
            return Ok("MenüBilgisi başarıyla silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenusById(int id)
        {
            var result = await _mediator.Send(new GetMenuByIdQuery(id));
            return Ok(result);
        }
    }
}
