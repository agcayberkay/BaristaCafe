using BaristaCafe.Application.Features.Mediatör.Commands.LocaitonCommands;
using BaristaCafe.Application.Features.Mediatör.Commands.TestimonialCommands;
using BaristaCafe.Application.Features.Mediatör.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestimonialsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetTestimonials()
        {
            var value = await _mediator.Send(new GetTestimonialQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonials(CreateTestimonialCommand command)
        {
            await _mediator.Send(command);
            return Ok("Müşteri Bilgisi başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonials(UpdateTestimonialCommand command)
        {
            await _mediator.Send(command);
            return Ok("Müşteri Bilgisi başarıyla güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTestimonials(int id)
        {
            await _mediator.Send(new RemoveTestimonialCommand(id));
            return Ok("Müşteri Bilgisi başarıyla silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonialsById(int id)
        {
            var result = await _mediator.Send(new GetTestimonialByIdQuery(id));
            return Ok(result);
        }
    }
}
