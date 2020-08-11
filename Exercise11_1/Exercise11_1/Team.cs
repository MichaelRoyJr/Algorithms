using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBudgetNamespace;

namespace TeamNamespace
{
    public abstract class Team : IBudget
    {
        private string headCoach;
        private string sport;
        private string location;

        //for implementing interface

        protected int avgTixSales;
        protected decimal avgTixPrice;
        protected decimal overhead;
        protected decimal tVMoney;
        protected int homeGames;

        public Team()
        {
            location = "MSU Athletics Department\nEast Lansing, MI";
        }

        public Team(string sportType, string headCoachName)
        {
            sport = sportType;
            headCoach = headCoachName;
            location = "MSU Athletics Department\nEast Lansing, MI";
        }


        public override string ToString()
        {
            return sport + " " + headCoach; 
        }

        public virtual string NextGame()
        {
            return "No team selected!";
        }

        public string HeadCoach
        {
            get
            {
                return headCoach;
            }
            set
            {
                headCoach = value;
            }
        }
        public string Sport
        {
            get
            {
                return sport;
            }
            set
            {
                sport = value;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
        }
        public int AvgTixSales
        {
            set
            {
                avgTixSales = value;
            }
        }
        public decimal AvgTixPrice
        {
            set
            {
                avgTixPrice = value;
            }
        }
        public decimal Overhead
        {
            set
            {
                overhead = value;
            }
        }
        public decimal TVMoney 
        {
            set
            {
                tVMoney = value;
            }
        }
        public int HomeGames
        {
            set
            {
                homeGames = value;
            }
        }


        //interface members
       
        public decimal CalculateCosts()
        {
            
            decimal foodCosts = (decimal)(avgTixSales * 2.0);
            decimal promos = (decimal)(avgTixSales * 2.75);
            return homeGames * (overhead + foodCosts + promos);
        }
        public decimal CalculateRevenue()
        {
            
            decimal tixDollars = (decimal)(avgTixPrice * avgTixSales);
            decimal concessions = (decimal)(avgTixSales * 11.25);
            return homeGames * (tVMoney + tixDollars + concessions);
        }
        public void ShowRevenueStats()
        {
            Console.WriteLine("Revenue: {0:C}", CalculateRevenue());
            Console.WriteLine("Costs: {0:C}", CalculateCosts());
            Console.WriteLine("Profit: {0:C}", (CalculateRevenue() - CalculateCosts()));
            Console.WriteLine();
        }
    }
}
