using System;

namespace GetSign_Method
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string sign = GetSign(input);
            Console.WriteLine($"The number {input} is {sign}");
        }

        private static string GetSign(int input)
        {
            if (input > 0)
            {
                return "positive";
            }
            else if (input < 0)
            {
                return "negative";
            }
            else
            {
                return "zero";
            }
        }
    }
}
