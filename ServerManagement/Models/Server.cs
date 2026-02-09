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
        public bool IsOnline { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
    }
}
