using Microsoft.AspNetCore.Mvc.RazorPages;
using PeopleKPMG.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace PeopleKPMG.Web.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly PersonService _personService;

        public IndexModel(PersonService personService)
        {
            _personService = personService;
        }

        [BindProperty]
        public Person Person { get; set; }

        public List<Person> Persons { get; set; }

        public async Task OnGetAsync()
        {
            try
            {
                Persons = await _personService.GetPersonsAsync();
            }
            catch (Exception ex)
            {
                Persons = new List<Person>();
            }
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("Id invalido informado.");
                }

                await _personService.DeletePersonAsync(id);
                return RedirectToPage("Index");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
