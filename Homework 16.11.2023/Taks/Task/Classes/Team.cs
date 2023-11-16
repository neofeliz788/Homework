using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Team
    {
        Countries country;
        List<Player> players = new List<Player>();
        public Countries Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public List<Player> Players
        {
            get
            {
                return players;
            }
            set
            {
                players = value;
            }
        }
        public Team(Countries country, List<Player> players)
        {
            this.country = country;
            this.players = players;
        }
    }
}
