using FootballWCSB.Data.DAO;
using FootballWCSB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballWCSB
{
    public class MatchManager
    {
        private MatchDAO MatchDAO;

        public MatchManager()
        {
            this.MatchDAO = MatchDAO.GetInstance();
        }

        public Match StartMatch (string homeTeam, string awayTeam)
        {
            if (MatchDAO.Exists(homeTeam, awayTeam))
                throw new Exception("There is already a match running for these teams");

            return MatchDAO.Create(homeTeam, awayTeam);
        }

        public Match UpdateScore(Match item, int? homeScore, int? awayScore)
        {
            if (!MatchDAO.Exists(item.HomeTeam, item.AwayTeam))
                throw new Exception("The provided match does not exist in the scoreboard");

            if ((homeScore ?? 0) < 0 || (awayScore ?? 0) < 0)
                throw new Exception("Can't set a negative score");

            if (homeScore != null)
                item.HomeScore = homeScore ?? 0;

            if (awayScore != null)
                item.AwayScore = awayScore ?? 0;

            return MatchDAO.Update(item);
        }

        public void FinishMatch (Match item)
        {
            if (!MatchDAO.Exists(item.HomeTeam, item.AwayTeam))
                throw new Exception("There is no match running for the specified teams");

            MatchDAO.Remove(item);
        }

        public List<Match> GetSummary()
        {
            return MatchDAO.GetAll()
                .OrderByDescending(x => x.TotalScore)
                .ThenByDescending(x => x.MatchDate)
                .ToList();
        }
    }
}
