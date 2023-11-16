using System.Collections.Generic;

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
        public void AddGamesToBigRace(BigRaceShow brs, List<Game> games)
        {
            foreach (var game in games)
            {
                brs.AddGame(game);
            }
        }
        public void AddGameToBigRace(BigRaceShow brs, Game game)
        {
            brs.AddGame(game);
        }
        public void AddTeamsToBigRace(BigRaceShow brs, List<Team> teams)
        {
            foreach (var team in teams)
            {
                brs.AddTeam(team);
            }
        }
    }
}
