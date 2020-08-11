using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_10
{
    class TriangleApp
    {
        public static int GetSpecs(out char character)
        {
            char charValue;
            Console.Write("How high would you like the triangle to be? ");
            int height = int.Parse(Console.ReadLine());
            if (height > 10 || height < 1)
                height = 3;
            Console.Write("Which character would you like to use? ");
            string input =Console.ReadLine();
            if (char.TryParse(input, out character) == false)
                character = '*';
            return height;
            
        }

        static void Main(string[] args)
        {
            int peak;
            char character;

            peak = GetSpecs(out character);
            Triangle triangle = new Triangle(peak, character);
            triangle.Display();
            
        }
    }
}
