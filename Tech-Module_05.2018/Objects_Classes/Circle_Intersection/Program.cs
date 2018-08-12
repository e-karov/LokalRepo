using System;

namespace Circle_Intersection
{
    class Program
    {
        static void Main()
        {
            
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point()
            {

            }
            public Point (int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public Point(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        class Circle
        {
            public Point Center { }
        }
    }
}
