using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvexHulls
{
    class ConvexHulls
    {
        static void Main(string[] args)
        {
            const int noOfPoints = 10;
            const int max = 10;
            Point[] pointArray = populate(noOfPoints, max);

            Console.WriteLine("Content of pointArray:");
            for (int i = 0; i < pointArray.Length; i++)
            {
                Console.WriteLine(pointArray[i]);
            }
            
        }

        public static Point[] populate(int points, int max)
        {
            Point[] pointArray = new Point[points];
            Random rand = new Random();
            for (int i = 0; i < points; i++)
            {
                pointArray[i] = new Point(rand.NextDouble() * max, rand.NextDouble() * max);
            }
            return pointArray;        }
    }
}
