using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ManagementSystemOfGames.Models;
using ManagementSystemOfGames.Persistence;

namespace ManagerSystemOfGames.Repositories
{
    public class GenderRepository : IGenderRepository
    {
        private GamesContext _context;

        public GenderRepository(GamesContext gamesContext) {
            _context = gamesContext;
        }
        
        public void Register(Gender gender)
        {
            _context.Genders.Add(gender);
        }

        public IList<Gender> List()
        {
           return  _context.Genders.ToList();
        }

        public IList<Gender> SearchFor(Expression<Func<Gender, bool>> filter)
        {
            return _context.Genders.Where(filter).ToList();
        }
    }
}