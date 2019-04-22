using System;

namespace _03.Longer_Line
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double[] longerLine = GetLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
            PrintLongerLine(longerLine);
        }

        private static double[] GetLongerLine(double x1, double y1, double x2, double y2,
            double x3, double y3, double x4, double y4)
        {
            double line1 = Math.Sqrt(Math.Pow((x1 -x2), 2) + Math.Pow((y1 - y2),2));
            double line2 = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3 - y4),2));
            double[] longerLine = new double[4];

            if (line1 >= line2)
            {
                longerLine[0] = x1;
                longerLine[1] = y1;
                longerLine[2] = x2;
                longerLine[3] = y2;
            }
            else
            { 
                longerLine[0] = x3;
                longerLine[1] = y3;
                longerLine[2] = x4;
                longerLine[3] = y4;
            }


            return longerLine;
        }

        private static double GetPointDistance(double x, double y)
        {
            double distance = Math.Sqrt((x * x) + (y * y));
            return distance;
        }

        private static void PrintLongerLine(double[] longerLine)
        {
            double pointADistance = GetPointDistance(longerLine[0], longerLine[1]);
            double pointBDisance = GetPointDistance(longerLine[2], longerLine[3]);

            if (pointADistance <= pointBDisance)
            {
                Console.Write($"({longerLine[0]}, {longerLine[1]})");
                Console.WriteLine($"({longerLine[2]}, {longerLine[3]})");
            }

            else
            {
                Console.Write($"({longerLine[2]}, {longerLine[3]})");
                Console.WriteLine($"({longerLine[0]}, {longerLine[1]})");
            }
        }
    }
}
