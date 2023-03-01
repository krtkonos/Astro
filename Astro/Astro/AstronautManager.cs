using Astro.Models;

namespace Astro.Models
{
    public class AstronautManager
    {
        public List<Astronaut> astronauts = new List<Astronaut>();

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
        public Astronaut GetAstronautById(int id)
        {
            return astronauts.FirstOrDefault(a => a.Id == id);
        }
    }

}
