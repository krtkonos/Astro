using Astro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Astro.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AstronautManager astronautManager;

        public IndexModel(AstronautManager astronautManager)
        {
            this.astronautManager = astronautManager;
        }

        public List<Astronaut> Astronauts { get; set; }

        [BindProperty]
        public Astronaut NewAstronaut { get; set; }

        public void OnGet()
        {
            Astronauts = astronautManager.GetAllAstronauts();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                astronautManager.AddAstronaut(NewAstronaut);
                return RedirectToPage();
            }

            Astronauts = astronautManager.GetAllAstronauts();
            return Page();
        }
    }

}