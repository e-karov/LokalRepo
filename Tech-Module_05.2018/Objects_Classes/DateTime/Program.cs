using System;
using System.Globalization;
using System.Linq;

namespace Date_Time
{
    class Program
    {
        static void Main()
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            double distance =  CalcDistance(p1, p2);
            Console.WriteLine("Distance: {0:f3}", distance);


        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static double CalcDistance(Point p1, Point p2)
        {
            int sideA = Math.Abs(p1.X - p2.X);
            int sideB = Math.Abs(p1.Y - p2.Y);

            double distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return distance;
        }

        static Point ReadPoint()
        {
            int[] input = Console.ReadLine().Split()
                        .Select(int.Parse).ToArray();
            Point point = new Point();

            point.X = input[0];
            point.Y = input[1];
            return point;
        }
    }
}
