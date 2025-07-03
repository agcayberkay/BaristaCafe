using BaristaCafe.Application.Features.Mediatör.Commands.MenuItemCommands;
using BaristaCafe.Application.Features.Mediatör.Queries.MenuItemQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MenuItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetMenuItems()
        {
            var value = await _mediator.Send(new GetMenuItemQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMenuItems([FromBody] CreateMenuItemCommand command)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await _mediator.Send(command);
                return Ok("Menü Item Bilgisi başarıyla eklendi.");
            }
            catch (ArgumentException ex)
            {
                // Burada özel hata mesajını dönüyorsun
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                // Genel hata için 500 dönebilirsin
                return StatusCode(500, new { message = "Menu Id Bulunamadı!" });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMenuItems([FromBody]UpdateMenuItemCommand command)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                await _mediator.Send(command);
                return Ok("Menü Item Bilgisi başarıyla güncellendi.");
            }
            catch (ArgumentException ex)
            {

                return NotFound("Menü Item Bilgisi güncellenirken bir hata oluştu. Lütfen tekrar deneyin.");
            }
            catch (Exception ex) 
            {
                // Genel hata için 500 dönebilirsin
                return StatusCode(500, new { message = "Menu Id Bulunamadı!" });
            }
           
            
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMenuItems(int id)
        {
            await _mediator.Send(new RemoveMenuItemCommand(id));
            return Ok("Menü Item Bilgisi başarıyla silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenuItemsById(int id)
        {
            var result = await _mediator.Send(new GetMenuItemByIdQuery(id));
            return Ok(result);
        }
    }
}
