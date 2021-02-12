using FootballWCSB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWCSB.Data.DAO
{
    public class MatchDAO : @internal.DAOBase<Match>
    {
        protected MatchDAO() : base()
        {
        }
        internal override void Initialize()
        {
            ItemsCollection = new List<Match>()
            {
                new Match("Mexico", "Canada", 0, 5),
                new Match("Spain", "Brazil", 10, 2),
                new Match("Germany", "France", 2, 2),
                new Match("Uruguay", "Italy", 6, 6),
                new Match("Argentina", "Australia", 3, 1)
            };
        }
    }
}
