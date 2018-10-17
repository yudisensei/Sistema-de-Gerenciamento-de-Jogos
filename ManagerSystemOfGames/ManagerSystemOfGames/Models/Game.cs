using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagerSystemOfGames.Models
{
    public class Game
    {
        public int GameId { get; set; }

        public DateTime Release { get; set; }

        public Plataform Plataform { get; set; }

        public bool Avaliable { get; set; }

        //Relationship One To Many 
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
    }

 
}