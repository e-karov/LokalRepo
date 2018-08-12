using System;
using System.Collections.Generic;

namespace Temp_14._07._18
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrdoubleCloserPodouble(x1, y1, x2, y2);
        }

        static void PrdoubleCloserPodouble(double x1, double y1, double x2, double y2)
        {
            double distance1 = CalculatePitagorean(x1, y1);
            double distance2 = CalculatePitagorean(x2, y2);

            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

         static double CalculatePitagorean(double x, double y)
        {
            double distance = Math.Sqrt(x * x + y * y);
            return distance;
        }
    }
}
