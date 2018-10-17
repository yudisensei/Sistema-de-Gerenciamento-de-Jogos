using ManagementSystemOfGames.Models;
using System.Collections.Generic;


namespace ManagementSystemOfGames.ViewModel
{
    /*Design Pattern : ViewModel , allows implementation business rule in model to View**/
    public class GenderViewModel
    {
        public Gender Gender { get; set; }

        public IList<Game> Games { get; set; }
     }
}