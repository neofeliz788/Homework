using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Organizer
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Organizer(string name)
        {
            this.name = name;
        }
        public void AddGamesToBigRace(BigRaceShow brs, List<IGame> games)
        {
            foreach(var game in games)
            {
                brs.AddGame(game);
            }
        }
        public void AddGameToBigRace(BigRaceShow brs, IGame game)
        {
            brs.AddGame(game);
        }
        public void AddTeamsToBigRace(BigRaceShow brs, List<Team> teams)
        {
            foreach(var team in teams)
            {
                brs.AddTeam(team);
            }
        }
    }
}
