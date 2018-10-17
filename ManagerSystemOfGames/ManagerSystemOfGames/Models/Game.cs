using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManagementSystemOfGames.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DateRelease { get; set; }

        public Plataform Plataform { get; set; }

        public bool Avaliable { get; set; }

        //Relationship One To Many 
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
    }

 
}