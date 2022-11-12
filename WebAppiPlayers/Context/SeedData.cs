using WebAppiPlayers.Models;

namespace WebAppiPlayers.Context
{
    public static class SeedData
    {
        private static List<Player> Players = new List<Player>()//TODO insert startowe dane do bazy
        {
            new Player {Id = 1, LastName="Jordan"}
           };

        public static List<Player> GetAll()
        {
            return Players;
        }
        public static async void Seed(ApplicationDbContext context)
        {
            if (context.Players.Any())
            {
                return;
            }
            var player = new Player()
            {
                LastName = "Jordan",
            };

            context.Players.Add(player);
            await context.SaveChangesAsync();   
        }
    }
}





