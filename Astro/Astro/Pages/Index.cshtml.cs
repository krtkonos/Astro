using Astro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;

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
        [TempData]
        public string ErrorMessage { get; set; }


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
                InputCheck(NewAstronaut);
                if (!ModelState.IsValid)
                {
                    Astronauts = astronautManager.GetAllAstronauts();
                    ErrorMessage = "The text must not contain digits and special characters (like ?><:(){}!@#$%...)";
                    Astronauts = astronautManager.GetAllAstronauts();
                    return Page();
                }
                astronautManager.AddAstronaut(NewAstronaut);
                Astronauts = astronautManager.GetAllAstronauts();
                HttpContext.Response.Redirect(HttpContext.Request.Path);
                return Page();
            }
            else
            {
                ErrorMessage = "There were errors in the submitted form. Please fix them and try again.";
                Astronauts = astronautManager.GetAllAstronauts();
                return BadRequest();
            }
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
        private void InputCheck(Astronaut astronaut)
        {
            string regexPattern = "^[a-zA-Z ]+$";
            string[] propertiesToCheck = { "FirstName", "LastName", "Superpower" };
            foreach (string propertyName in propertiesToCheck)
            {
                string propertyValue = (string)astronaut.GetType().GetProperty(propertyName).GetValue(astronaut);
                if (!Regex.IsMatch(propertyValue, regexPattern))
                {
                    ModelState.AddModelError("NewAstronaut." + propertyName, "The " + propertyName + " field can only contain letters and spaces.");
                }
            }
        }

    }
}