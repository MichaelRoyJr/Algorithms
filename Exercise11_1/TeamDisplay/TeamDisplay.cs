using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamNamespace;
using BasketballTeamNamespace;
using FootballTeamNamespace;

namespace TeamDisplay
{
    class TeamDisplay
    {
        static void Main(string[] args)
        {
            BasketballTeam bBall = new BasketballTeam("basketball", "Tom Izzo", "Breslin Center");
            FootballTeam fBall = new FootballTeam("football", "Mark Dantonio", "Spartan Stadium");

            Console.WriteLine("MSU Sports Summary:");
            Console.WriteLine(bBall.mainLocation());
            Console.WriteLine();

            Console.WriteLine(bBall.ToString());
            Console.WriteLine(bBall.NextGame());
            Console.WriteLine();

            bBall.setSport();
            bBall.ShowRevenueStats();

            Console.WriteLine(fBall.ToString());
            Console.WriteLine(fBall.NextGame());
            Console.WriteLine();

            fBall.setSport();
            fBall.ShowRevenueStats();
        }
    }
}
