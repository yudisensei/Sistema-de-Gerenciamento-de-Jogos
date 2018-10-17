using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagementSystemOfGames.Models
{
    public class Gender
    {
        public int GenderId { get; set; }
        public string Name { get; set; }
        public IList<Game> Games  { get; set; }
    }
}