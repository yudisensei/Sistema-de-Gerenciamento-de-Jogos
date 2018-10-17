using ManagementSystemOfGames.Models;

using System.Data.Entity;


namespace ManagementSystemOfGames.Persistence
{
    public class GamesContext: DbContext
    {
        public DbSet<Game> Games { get; set; }

        public DbSet<Gender> Genders { get; set; }
    }
}