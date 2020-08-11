using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamNamespace;


namespace FootballTeamNamespace
{
    public class FootballTeam : Team
    {
        private string location;

        public FootballTeam() : base()
        {
        }

        public FootballTeam(string sprt, string coach, string field) : base(sprt, coach)
        {
            location = field;
        }

        public override string ToString()
        {
            return "MSU Spartans\n" + base.ToString() + "\n" + location;
        }

        public override string NextGame()
        {
            return "Bowl game tbd";
        }

        public new string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public void setSport()
        {
            AvgTixSales = 86400;
            AvgTixPrice = 54.55m;
            Overhead = 4000000m;
            TVMoney = 1300000m;
            HomeGames = 7;
        }
    }
}
