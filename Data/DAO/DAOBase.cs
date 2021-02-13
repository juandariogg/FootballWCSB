using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWCSB.Data.DAO
{
    namespace @internal
    {
        public abstract class DAOBase<T> where T : Entities.@internal.EntityBase
        {
            internal ICollection<T> ItemsCollection;

            internal abstract void Initialize();
            public abstract void Create(T item);
            public abstract T Update(T item);
            public abstract void Remove(T item);
            public abstract List<T> GetAll();

            protected DAOBase()
            {
                this.Initialize();
            }
        }
    }
    
}
