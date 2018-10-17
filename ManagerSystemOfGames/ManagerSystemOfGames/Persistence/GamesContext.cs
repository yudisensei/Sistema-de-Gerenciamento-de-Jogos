using ManagerSystemOfGames.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManagerSystemOfGames.Persistence
{
    public class GamesContext: DbContext
    {
        public DbSet<Game> Games { get; set; }

        public DbSet<Gender> Genders { get; set; }
    }
}