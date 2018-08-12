using System;

namespace Refactoring_Prime_Checker
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                bool isPrime = true;
                for (int divider = 2; divider <= Math.Sqrt(i); divider++)
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
