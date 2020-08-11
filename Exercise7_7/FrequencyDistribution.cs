using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_9
{
    class FrequencyDistribution
    {
        static void Main(string[] args)
        {
            int[] inputStream = new int[100];
            int[] tallies = new int[11];
            int i = 0;
            inputStream[i] = 0;
            string test;

            while (inputStream[i] != -99)
            {
                Console.Write("Enter a number between 0 and 10 (-99 to stop): ");
                test = Console.ReadLine();
                if (int.TryParse(test, out inputStream[i]) == false)
                {
                    Console.WriteLine("Invalid input: not an integer.");
                    
                }
                else if(inputStream[i] > 10 || inputStream[i] < 0)
                {
                    if (inputStream[i] != -99)
                    {
                        Console.WriteLine("Invalid input: out of range.");
                        
                    }
                }
                else
                {
                    tallies[inputStream[i]]++;
                    i++;
                }

            }
            string asterisks = "";
            for (int j = 0; j < 11; j++)
            {
                for (int k = 0; k < tallies[j]; k++)
                {
                    asterisks += "*";
                }
                Console.WriteLine("{0}|" + asterisks, j);
                asterisks = "";
            }
        }
    }
}
