using System;
using System.Linq;

namespace Closest_Two_Points
{
    class Program
    {
        static void Main()
        {
            Point[] poins = ReadPoints();
            Point[] theClosestTwo = ClosestTwoPoints(poins);

            PrintDistance(theClosestTwo);

            PrintPpoint(theClosestTwo[0]);
            PrintPpoint(theClosestTwo[1]);
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
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
        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            return points;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            int sideA = Math.Abs(p1.X - p2.X);
            int sideB = Math.Abs(p1.Y - p2.Y);

            double distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return distance;
        }

        static Point[] ClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestPoints = null;

            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1+1; p2 < points.Length; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;

                        closestPoints = new Point[] { points[p1], points[p2] };
                    }
                }

            }
            return closestPoints;
        }

        static void PrintPpoint(Point p1)
        {
            Console.WriteLine("{0}, {1}", p1.X, p1.Y);
        }

        static void PrintDistance(Point[] points)
        {
            double distance = CalcDistance(points[0], points[1]);
            Console.WriteLine("{0:f3}", distance);
        }
    }
}
