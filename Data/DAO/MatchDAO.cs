using FootballWCSB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballWCSB.Data.DAO
{
    public class MatchDAO : @internal.DAOBase<Match>
    {
        private static MatchDAO _instance;
        internal static MatchDAO GetInstance()
        {
            if (_instance == null)
                _instance = new MatchDAO();

            return _instance;
        }

        private MatchDAO() : base()
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
        public bool Exists (string homeTeam, string awayTeam)
        {
            return ItemsCollection.Any(x => x.HomeTeam == homeTeam && x.AwayTeam == awayTeam);
        }

        /// <summary>
        /// Creates a new match and registers it in the ItemsCollection.
        /// </summary>
        /// <param name="homeTeam">Name of the Home Team</param>
        /// <param name="awayTeam">Name of the Away Team</param>
        /// <returns>The created match</returns>
        public Match Create (string homeTeam, string awayTeam)
        {
            var match = new Match(homeTeam, awayTeam);
            Create(match);
            return match;
        }

        public override void Create (Match item)
        {
            ItemsCollection.Add(item);
        }

        /// <summary>
        /// Updates the score of the provided match
        /// The entry gets updated in the ItemsCollection
        /// </summary>
        /// <param name="item">Item to update</param>
        /// <param name="homeScore">Score of the Home Team. Allows null, won't update if no data provided</param>
        /// <param name="awayScore">Score of the Away Team. Allows null, won't update if no data provided</param>
        /// <returns>The updated item</returns>
        public override Match Update (Match item)
        {
            var collectionItem = ItemsCollection.FirstOrDefault(x => x.Id == item.Id);

            //In case the item does not exists in the collection it's added
            if (collectionItem == null)
            {
                return null;
            }

            collectionItem.HomeScore = item.HomeScore;
            collectionItem.AwayScore = item.AwayScore;

            return collectionItem;
        }

        public override void Remove (Match item)
        {
            ItemsCollection.Remove(item);
        }

        public override List<Match> GetAll()
        {
            return ItemsCollection.ToList();
        }
    }
}
