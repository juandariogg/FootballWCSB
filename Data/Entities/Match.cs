using System;

namespace FootballWCSB.Data.Entities
{
    public class Match : @internal.EntityBase
    {
        public Match(string homeTeam, string awayTeam, int homeScore = 0, int awayScore = 0)
        {
            this.Id = Guid.NewGuid();
            this.HomeTeam = homeTeam;
            this.HomeScore = homeScore;
            this.AwayTeam = awayTeam;
            this.AwayScore = awayScore;
            this.MatchDate = DateTime.Now;
        }

        #region private properties
        private Guid _id;
        private string _home_team;
        private string _away_team;
        private int _home_score;
        private int _away_score;
        private DateTime _match_date;
        #endregion

        #region public properties

        public Guid Id
        {
            get
            { return _id; }
            set
            { _id = value; OnPropertyChanged(); }
        }

        public string HomeTeam
        {
            get
            { return _home_team; }
            set
            { _home_team = value; OnPropertyChanged(); }
        }

        public string AwayTeam
        {
            get
            { return _away_team; }
            set
            { _away_team = value; OnPropertyChanged(); }
        }

        public int HomeScore
        {
            get 
            { return _home_score; }
            set
            { _home_score = value; OnPropertyChanged(); }
        }

        public int AwayScore
        {
            get
            { return _away_score; }
            set
            { _away_score = value; OnPropertyChanged(); }
        }

        public DateTime MatchDate
        {
            get
            { return _match_date; }
            set 
            { _match_date = value; OnPropertyChanged(); }
        }
        #endregion

        #region Not Mapped

        public int TotalScore
        {
            get
            { return HomeScore + AwayScore; }
        }

        #endregion
        public override bool Equals(object obj)
        {
            if (!(obj is Match item))
                return false;

            return item.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{this.HomeTeam} {this.HomeScore} - {this.AwayTeam} {this.AwayScore}";
        }
    }
}
