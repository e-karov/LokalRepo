using System;

namespace PowMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            double result =Power(num, pow);

            Console.WriteLine(result);
        }

        private static double Power(double num, int power)
        {
            double result = 1.0;
            for (int i = 1; i <= power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
