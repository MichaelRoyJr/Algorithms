using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacuumCleanerWorld
{
    class VacuumCleanerWorld
    {
        static void Main(string[] args)
        {
            //collect info and set up environment
            Environment world;
            string customResponse;
            Console.Write("Enter custom values? ");
            customResponse = Console.ReadLine();
            if (customResponse.ToLower() == "y")
            {
                Console.Write("Enter width: ");
                int width = int.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                int height = int.Parse(Console.ReadLine());
                world = new Environment(width, height);
                CollectInfo(world);
            }
            else
            {
                world = new Environment();
                world.SetDirt();
                world.SetInitialPosition();
            }

            //run simulation
            world.Run();

            //display score
            Console.WriteLine("Score after 1000 turns is: " + world.Score);
        }

        private static void CollectInfo(Environment world)
        {
            string input;
            string[] dirtySquares;
            Console.Write("Enter numbers of dirty squares (Enter for random): ");
            input = Console.ReadLine();
            if (input == "")
                world.SetDirt();
            else
            {
                dirtySquares = input.Split(' ');
                List<int> dirt = new List<int>();
                for (int i=0; i < dirtySquares.Length; i++)
                {
                    if (int.Parse(dirtySquares[i]) < world.Size)
                        dirt.Add(int.Parse(dirtySquares[i]));
                }
                world.SetDirt(dirt);
            }

            Console.Write("Enter starting position (Enter for random): ");
            input = "";
            input = Console.ReadLine();
            if (input == "")
                world.SetInitialPosition();
            else
                world.SetInitialPosition(int.Parse(input));
        }
    }
}
