using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvexHulls
{
    class Point
    {
        private double x;
        private double y;

        public Point(double xValue, double yValue)
        {
            x = xValue;
            y = yValue;
        }

        public bool equals(Point point2)
        {
            if (this.x == point2.X && this.y == point2.Y)
            {
                return true;
            }
            else
                return false;
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }


    }
}
