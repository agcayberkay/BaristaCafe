using BaristaCafe.Application.Features.Mediatör.Commands.ContactCommands;
using BaristaCafe.Application.Features.Mediatör.Queries.ContactQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            var value = await _mediator.Send(new GetContactQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContacts(CreateContactCommand command)
        {
            await _mediator.Send(command);
            return Ok("İletişim Bilgisi başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContacts(UpdateContactCommand command)
        {
            await _mediator.Send(command);
            return Ok("İletişim Bilgisi başarıyla güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteContacts(int id)
        {
            await _mediator.Send(new RemoveContactCommand(id));
            return Ok("İletişim Bilgisi başarıyla silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactsById(int id)
        {
            var result = await _mediator.Send(new GetContactByIdQuery(id));
            return Ok(result);
        }
    }
}
