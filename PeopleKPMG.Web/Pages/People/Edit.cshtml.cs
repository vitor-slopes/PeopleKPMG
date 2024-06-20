using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PeopleKPMG.Web.Models;
using PeopleKPMG.Application.Services;

namespace PeopleKPMG.Web.Pages.People
{
    public class EditModel : PageModel
    {
        private readonly PersonService _personService;

        public EditModel(PersonService personService)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _personService.UpdatePersonAsync(Person.Id, Person);
            return RedirectToPage("Index");
        }
    }
}
