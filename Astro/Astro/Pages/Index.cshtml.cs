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
                /*if (Astronauts == null || Astronauts.Count == 0)
                {
                    NewAstronaut.Id = 1;
                }
                else
                {
                    for (int i = 0; i < Astronauts.Count; i++)
                    {
                        Astronauts[i].Id = i + 1;
                    }
                }*/
                Astronauts = astronautManager.GetAllAstronauts();
                Console.WriteLine("New astronaut added: " + NewAstronaut.FirstName + " " + NewAstronaut.LastName + " " + NewAstronaut.Id);
                Console.WriteLine("Count aftergetall : " + Astronauts.Count);
                return Page();
            }
            return BadRequest();
        }
        public IActionResult OnPostDelete(int id)
        {
            Astronaut astronaut = astronautManager.GetAstronautById(id);
            if (astronaut == null)
            {
                return NotFound();
            }
            astronautManager.RemoveAstronaut(astronaut);
            return RedirectToPage();
        }
    }
}