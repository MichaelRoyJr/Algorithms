using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Exercise13_2
{
    class FileStats
    {
        static void Main(string[] args)
        {
           
            int sum = 0,
                count = 0,
                high = 0,
                low = 10000,
                intValue;
            double avg;
            string inValue;

            try
            {
                StreamReader inputFile = new StreamReader("TwentyInts.txt");
                while ((inValue = inputFile.ReadLine()) != null)
                {
                    intValue = int.Parse(inValue);
                    count++;
                    sum += intValue;

                   // Console.WriteLine(intValue);

                    if (intValue > high)
                        high = intValue;
                    if (intValue < low)
                        low = intValue;
                    
                }
                inputFile.Close();
            }
            catch (System.IO.IOException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            avg = (double)(sum / count);

            Console.WriteLine("Number of values processed: {0}", count);
            Console.WriteLine("Average: {0:f2}", avg);
            Console.WriteLine("High value: {0}", high);
            Console.WriteLine("Low value: {0}", low);

            
            
        }
    }
}
