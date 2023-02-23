using Astro.Models;

namespace Astro.Models
{
    public class AstronautManager
    {
        private List<Astronaut> astronauts = new List<Astronaut>();

        public void AddAstronaut(Astronaut astronaut)
        {
            astronauts.Add(astronaut);
        }

        public void RemoveAstronaut(Astronaut astronaut)
        {
            astronauts.Remove(astronaut);
        }

        public List<Astronaut> GetAllAstronauts()
        {
            return astronauts;
        }
    }

}
