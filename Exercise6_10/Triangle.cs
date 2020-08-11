using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_10
{
    class Triangle
    {
        private int peak;
        private char character;

        public Triangle(int peakHeight, char display)
        {
            peak = peakHeight;
            character = display;
        }

        public void Display()
        {
            for (int i = 1; i <= peak; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine("");
            }
            for (int i = peak - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine("");
            }
        }
    }
}
