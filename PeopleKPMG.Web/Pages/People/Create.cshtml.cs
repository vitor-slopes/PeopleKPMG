using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PeopleKPMG.Web.Models;
using PeopleKPMG.Application.Services;

namespace PeopleKPMG.Web.Pages.People
{
    public class CreateModel : PageModel
    {
        private readonly PersonService _personService;

        public CreateModel(PersonService personService)
        {
            _personService = personService;
        }

        [BindProperty]
        public Person Person { get; set; }

        [BindProperty]
        public string HasDependents { get; set; }

        public void OnGet()
        {
            Person = new Person();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (HasDependents == "Não")
            {
                Person.Dependents = new List<Dependent>();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _personService.CreatePersonAsync(Person);
            return RedirectToPage("Index");
        }
    }
}
