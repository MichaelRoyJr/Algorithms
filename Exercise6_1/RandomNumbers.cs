using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6_1
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int smallest = 0,
                largest = 0,
                odd = 0,
                toTest;

            for (int i = 0; i < 1000; i++)
            {
                toTest = number.Next(100000);
                if (toTest % 2 == 1)
                    odd++;
                if (toTest < smallest)
                    smallest = toTest;
                if (toTest > largest)
                    largest = toTest;
            }
            string output = odd + " Odd numbers were generated.\nThe largest was " + largest + ", and the smallest was " + smallest;
            MessageBox.Show(output, "Random Number Summary", MessageBoxButtons.OK);
            //Console.WriteLine(odd + " Odd numbers were generated.");
            //Console.WriteLine("The largest was " + largest + ", and the smallest was " + smallest);
        }
    }
}
