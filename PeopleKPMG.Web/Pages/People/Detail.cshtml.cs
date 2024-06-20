using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PeopleKPMG.Web.Models;

namespace PeopleKPMG.Web.Pages.People
{
    public class DetailModel : PageModel
    {
        private readonly PersonService _personService;

        public DetailModel(PersonService personService)
        {
            _personService = personService;
        }

        [BindProperty]
        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Person = await _personService.GetPersonByIdAsync(id);
            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
