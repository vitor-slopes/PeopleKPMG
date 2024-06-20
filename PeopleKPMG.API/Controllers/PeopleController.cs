using Microsoft.AspNetCore.Mvc;
using PeopleKPMG.Application.DTOs;
using PeopleKPMG.Application.Interfaces;

namespace PeopleKPMG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PeopleController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonDto>>> Get()
        {
            var persons = await _personService.GetAllPersonsAsync();
            return Ok(persons);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonDto>> Get(int id)
        {
            var person = await _personService.GetPersonByIdAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PersonDto personDto)
        {
            await _personService.AddPersonAsync(personDto);
            return CreatedAtAction(nameof(Get), new { id = personDto.Id}, personDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PersonDto personDto)
        {
            var existingPerson = await _personService.GetPersonByIdAsync(id);
            if (existingPerson == null)
            {
                return NotFound();
            }
            await _personService.UpdatePersonAsync(id, personDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existingPerson = await _personService.GetPersonByIdAsync(id);
            if(existingPerson == null)
            {
                return NotFound();
            }
            await _personService.DeletePersonAsync(id);
            return NoContent();            
        }

    }
}
