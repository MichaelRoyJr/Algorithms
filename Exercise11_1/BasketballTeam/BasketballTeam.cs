using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamNamespace;
using IBudgetNamespace;

namespace BasketballTeamNamespace
{
    public class BasketballTeam : Team, IBudget
    {
        private string location;

        public BasketballTeam() : base()
        {
        }

        public BasketballTeam(string sprt, string coach, string court) : base(sprt, coach)
        {
            location = court;
        }

        public override string ToString()
        {
            return "MSU Spartans\n" + base.ToString() + "\n" + location;
        }

        public override string NextGame()
        {
            return "12-3-19 Duke";
        }

        public string mainLocation()
        {
            return base.Location;
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
            AvgTixSales = 11200;
            AvgTixPrice = 21.50m;
            Overhead = 250000m;
            TVMoney = 240000m;
            HomeGames = 16;
        }
    }
}
