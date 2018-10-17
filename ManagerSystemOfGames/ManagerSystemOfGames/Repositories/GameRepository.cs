using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ManagementSystemOfGames.Models;
using ManagementSystemOfGames.Persistence;


namespace ManagerSystemOfGames.Repositories
{
    public class GameRepository : IGameRepository
    {
        private GamesContext _context;

        public GameRepository(GamesContext _gamesContext) {
            _context = _gamesContext;
        }
        public void Update(Game game)
        {
            _context.Entry(game).State = EntityState.Modified;
        }

        public void Register(Game game)
        {
            _context.Games.Add(game);
        }

        public void Delete(int gameId)
        {
            var game = _context.Games.Find(gameId);
            _context.Games.Remove(game);
        }

        public IList<Game> List()
        {
            return _context.Games.ToList();
        }

        public Game Search(int gameId)
        {
            return _context.Games.Find(gameId);
        }

        public IList<Game> SearchFor(Expression<Func<Game, bool>> filter)
        {
            return _context.Games.Where(filter).ToList();
        }

    }
}