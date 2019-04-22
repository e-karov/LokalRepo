using System;

namespace _02.Center_Point
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPoint(x1, y1, x2, y2);

        }

        private static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double pointXDistance = GetPointDistance(x1, y1);
            double pointYDisance = GetPointDistance(x2, y2);

            if (pointXDistance <= pointYDisance)
            {
                Console.WriteLine($"({x1}, {y1})");
            }

            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double GetPointDistance(double x, double y)
        {
            double distance = Math.Sqrt((x * x) + (y * y));
            return distance;
        }
    }
}
