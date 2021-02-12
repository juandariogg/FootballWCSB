namespace FootballWCSB.Data.Entities
{
    public class Match : @internal.EntityBase
    {
        public Match(string homeTeam, string awayTeam, int homeScore = 0, int awayScore = 0)
        {
            this.HomeTeam = homeTeam;
            this.HomeScore = homeScore;
            this.AwayTeam = awayTeam;
            this.AwayScore = awayScore;
        }

        #region private properties
        private string _home_team;
        private string _away_team;
        private int _home_score;
        private int _away_score;
        #endregion

        #region public properties
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
        #endregion
    }
}
