using ManagerSystemOfGames.Persistence;
using ManagerSystemOfGames.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagerSystemOfGames.Units
{
    public class UnitOfWork : IDisposable
    {

        private GamesContext _context = new GamesContext();

        private IGameRepository _gameRepository;

        public IGameRepository GameRepository/**name of object for IGameRepostory type*/ {
            get {
                /**if instance of _gameRepository is null , then create a new instance */
                if (_gameRepository == null) {
                    _gameRepository = new GameRepository(_context);
                }
                return _gameRepository;
            }
        }


        private IGenderRepository _genderRepository;

                                    
        public IGenderRepository GenderRepository{ 
            get
            {
                if (_genderRepository == null)
                {
                    _genderRepository = new GenderRepository(_context);
                }
                return _genderRepository;
            }
         }

        /**Commit*/
        public void Save() {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null) {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}