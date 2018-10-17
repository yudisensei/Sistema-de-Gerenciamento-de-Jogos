using ManagerSystemOfGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSystemOfGames.Repositories
{
    public interface IGenderRepository
    {

        void Register(Gender gender);
        IList<Gender> List();
        IList<Gender> SearchFor(Expression<Func<Gender, bool>> filter);

    }
}
