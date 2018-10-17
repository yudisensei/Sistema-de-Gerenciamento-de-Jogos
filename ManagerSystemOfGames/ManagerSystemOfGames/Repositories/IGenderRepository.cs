using ManagementSystemOfGames.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace ManagerSystemOfGames.Repositories
{
    public interface IGenderRepository
    {

        void Register(Gender gender);
        IList<Gender> List();
        IList<Gender> SearchFor(Expression<Func<Gender, bool>> filter);

    }
}
