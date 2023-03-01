using Astro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Astro.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AstroController : ControllerBase
    {
        private readonly AstronautManager astronautManager;

        public AstroController(AstronautManager astronautManager)
        {
            this.astronautManager = astronautManager;
        }

        [HttpGet]
        public IEnumerable<Astronaut> Get()
        {
            return astronautManager.GetAllAstronauts();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Astronaut astronaut)
        {
            astronautManager.AddAstronaut(astronaut);

            return CreatedAtAction(nameof(Get), new { id = astronaut.Id }, astronaut);
        }
    }
}
