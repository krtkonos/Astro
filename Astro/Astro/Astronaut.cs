using System;
using System.ComponentModel.DataAnnotations;

namespace Astro.Models
{
    public class Astronaut
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a date of birth.")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please enter a superpower.")]
        public string Superpower { get; set; }
    }

}
