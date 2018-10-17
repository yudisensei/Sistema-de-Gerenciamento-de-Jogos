
using ManagementSystemOfGames.Models;
using System;
using System.Collections.Generic;

using System.Linq.Expressions;


namespace ManagerSystemOfGames.Repositories
{
  public interface IGameRepository
    {
        void Register(Game game);
        void Update(Game game);
        void Delete(int gameId);
        Game Search(int gameId);
        IList<Game> List();
        IList<Game> SearchFor(Expression<Func<Game, bool>> filter);

    }
}
