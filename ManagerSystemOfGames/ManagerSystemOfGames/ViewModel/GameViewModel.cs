using ManagementSystemOfGames.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ManagementSystemOfGames.ViewModel
{
    /*Design Pattern : ViewModel , allows implementation business rule in model to View**/
    public class GameViewModel
    {
        public Game Game { get; set; }
        public IList<Game> Games  { get; set; }

        public SelectList Genders { get; set; }

        public int GenderId { get; set; }

    }
}