using System;

namespace _04.Multplication_Sign
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            string numberSign = CheckProductSign(a, b, c);
            Console.WriteLine(numberSign);
        }

        private static string CheckProductSign(double a, double b, double c)
        {
            string result = "";
            if (a == 0 || b == 0 || c== 0)
            {
                result = "zero";
            }

            else if (a < 0 && b > 0 && c > 0)
            {
                result = "negative";
            }

            else if (b < 0 && a > 0 && c > 0)
            {
                result = "negative";
            }

            else if (c < 0 && a > 0 && b > 0)
            {
                result = "negative";
            }

            else if (a < 0 && b < 0 && c < 0)
            {
                result = "negative";
            }

            else
            {
                result = "positive";
            }
            return result;
        }
    }
}
