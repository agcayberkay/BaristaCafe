using BaristaCafe.Application.Features.Mediatör.Commands.WorkingHoursCommands;
using BaristaCafe.Application.Features.Mediatör.Queries.WorkingHoursQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkingHoursesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkingHoursesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetWorkingHourses()
        {
            var value = await _mediator.Send(new GetWorkingHoursQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWorkingHourses(CreateWorkingHoursCommand command)
        {
            await _mediator.Send(command);
            return Ok("Çalışma SaatiBilgisi başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWorkingHourses(UpdateWorkingHoursCommand command)
        {
            await _mediator.Send(command);
            return Ok("Çalışma SaatiBilgisi başarıyla güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteWorkingHourses(int id)
        {
            await _mediator.Send(new RemoveWorkingHoursCommand(id));
            return Ok("Çalışma SaatiBilgisi başarıyla silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorkingHoursesById(int id)
        {
            var result = await _mediator.Send(new GetWorkingHoursByIdQuery(id));
            return Ok(result);
        }
    }
}

