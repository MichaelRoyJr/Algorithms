using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmsAssignment6_1
{
    class TwoSum
    {
        static void Main(string[] args)
        {
            StreamReader inFile;
            Dictionary<string, string> table = new Dictionary<string, string>();
            string inValue;
            int count = 0;

            try
            {
                inFile = new StreamReader("algo1-programming_prob-2sum.txt");
                while ((inValue = inFile.ReadLine()) != null)
                {
                    try
                    {
                        table.Add(inValue, inValue);
                    }
                    catch
                    {
                    }
                }
                inFile.Close();
                for (long t = -10000; t <= 10000; t++)
                {
                    foreach (string key in table.Keys)
                    {
                        long x = long.Parse(key);
                        long y = t - x;
                        if (table.ContainsKey(y.ToString()) && x != y)
                        {
                            count++;
                            break;
                        }
                    }
                    //inFile.Close();
                    Console.WriteLine("t = " + t);
                }

                Console.WriteLine("Answer = " + count);                  
                
            }
            catch (System.IO.IOException exc)
            {
                Console.WriteLine(exc.Message);
            }            
        }
    }
}
