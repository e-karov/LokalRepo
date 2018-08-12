using System;
using System.Collections.Generic;

namespace Class_Point
{
    class Program
    {
        static void Main()
        {
            List<Point> points = new List<Point>();

            points.Add(new Point() { X = 1, Y = 2});

            foreach (var point in points)
            {
                Console.WriteLine(point.X);
                points[0].X = 3;
                Console.WriteLine(point.X);
            }

           
        }
    }

    class Point
    {

        public int X { get; set; }
        public int Y { get; set; }
    }
}
