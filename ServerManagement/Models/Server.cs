using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models
{
    public class Server
    {
        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2); // Generates a random number between 0 and 1
            IsOnline = randomNumber != 0; // Sets IsOnline to true if the random number is 1, otherwise false
        }

        public int ServerId { get; set; }
        public bool IsOnline { get; set; }  // Doesn't need Data Annotations because it will always have a value, either true or false, and it will be set in the constructor

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? City { get; set; }
    }
}
