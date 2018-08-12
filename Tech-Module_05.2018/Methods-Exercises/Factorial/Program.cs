using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

           
                Console.WriteLine(TrailIngZerosCount(Factorial(n)));
                
          
        }

        static BigInteger  Factorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                
                factorial *= i;
            }
            return factorial;
        }

        static int TrailIngZerosCount(BigInteger number)
        {
            string numberStr = number.ToString();
            int counter = 0;

            while (number % 10 == 0)
            {
                BigInteger digit = number % 10;
                if (digit == 0)
                {
                    counter++;
                    number /= 10;
                }
            }
            return counter;
        }
    }
}
