using System;
using System.Numerics;

namespace _09.Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double result = FactorialDivision(a, b);
            Console.WriteLine($"{result:F2}");
        }

        static double GetFactorial(int number)
        {
            double factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static double FactorialDivision(int a, int b)
        {
            double result = GetFactorial(a) / GetFactorial(b);

            return result;
        }
    }
}
