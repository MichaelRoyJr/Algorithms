using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_3
{
    class RectangleFun
    {
        static void Main()
        {
            int width,
                height,
                perimeter,
                area;
            GetDimensions(out height, out width);
            area = CalculateArea(height, width);
            perimeter = CalculatePerimeter(height, width);
            DisplayResults(height, width, perimeter, area);
        }

        public static void GetDimensions(out int height, out int width)
        {
            Console.Write("Enter the rectangle's height: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Enter the rectangle's width: ");
            width = int.Parse(Console.ReadLine());
;        }

        public static int CalculateArea(int height, int width)
        {
            return height * width;
        }

        public static int CalculatePerimeter(int height, int width)
        {
            return 2 * height + 2 * width;
        }

        public static void DisplayResults(int height, int width, int perimeter, int area)
        {
            Console.WriteLine("{0,-10:F0}{1,-10:F0}{2,-10:F0}{3,-10:F0}", "Height", "Width", "Perimeter", "Area");
            Console.WriteLine("{0,-10:F0}{1,-10:F0}{2,-10:F0}{3,-10:F0}", height, width, perimeter, area);
        } 
    }
}
