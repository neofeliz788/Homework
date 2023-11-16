using System.Collections.Generic;

namespace Task
{
    class BigRaceShow
    {
        List<Team> teams = new List<Team>();
        List<Game> games = new List<Game>();
        private static BigRaceShow bigRace = null;
        public List<Team> Teams
        {
            get
            {
                return teams;
            }
            set
            {
                teams = value;
            }
        }
        public List<Game> Games
        {
            get
            {
                return games;
            }
            set
            {
                games = value;
            }
        }
        public static BigRaceShow getInstance()
        {
            if (bigRace == null)
            {
                bigRace = new BigRaceShow();
            }
            return bigRace;
        }
        public void AddGame(Game game)
        {
            games.Add(game);
        }
        public void AddTeam(Team team)
        {
            teams.Add(team);
        }
        public void Start(Game game)
        {
            game.Play();
        }
    }
}
