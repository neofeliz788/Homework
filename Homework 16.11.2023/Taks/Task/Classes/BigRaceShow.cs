using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class BigRaceShow
    {
        List<Team> teams = new List<Team>();
        List<IGame> games = new List<IGame>();
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
        public List<IGame> Games
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
        public void AddGame(IGame game)
        {
            games.Add(game);
        }
        public void AddTeam(Team team)
        {
            teams.Add(team);
        }
        public void Start(IGame game)
        {
            game.Play();
        }
    }
}
