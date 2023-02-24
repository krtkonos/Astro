using Astro.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using System.Threading;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Astro
{
    public class Container
    {
    }
    /*@page
@model IndexModel

<h1> Astronauts</h1>

<table>
    <thead>
        <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Date of Birth</th>
            <th>Superpower</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
        @foreach (var astronaut in Model.Astronauts)
    {
            < tr >
                < td > @astronaut.FirstName </ td >
                < td > @astronaut.LastName </ td >
                < td > @astronaut.DateOfBirth.ToShortDateString() </ td >
                < td > @astronaut.Superpower </ td >
                < td >
                    < form method = "post" asp - page - handler = "delete" asp - route - id = "@astronaut.FirstName" >
                        < button type = "submit" > Delete </ button >
                    </ form >
                </ td >
            </ tr >
        }
    </tbody>
</table>

<h2>Add Astronaut</h2>

<form method = "post" >
    < div >
        < label for="firstName">First Name:</label>
        <input type = "text" id= "firstName" name= "NewAstronaut.FirstName" required />
    </div>
    <div>
        <label for="lastName">Last Name:</label>
        <input type = "text" id= "lastName" name= "NewAstronaut.LastName" required />
    </div>
    <div>
        <label for="dateOfBirth">Date of Birth:</label>
        <input type = "date" id= "dateOfBirth" name= "NewAstronaut.DateOfBirth" required />
    </div>
    <div>
        <label for="superpower">Superpower:</label>
        <input type = "text" id= "superpower" name= "NewAstronaut.Superpower" required />
    </div>
    <button type = "submit" > Add </ button >
</ form >*/


//===========================================

   /* using Astro.Models;
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
        } */
}
