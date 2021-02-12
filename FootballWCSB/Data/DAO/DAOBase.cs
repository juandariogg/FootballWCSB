using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWCSB.Data.DAO
{
    public abstract class DAOBase<T> where T : Entities.EntityBase
    {
        internal ICollection<T> ItemsCollection;

        internal abstract void Initialize();

        protected DAOBase()
        {
            this.Initialize();
        }
    }
}
