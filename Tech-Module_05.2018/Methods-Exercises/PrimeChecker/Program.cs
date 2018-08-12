using System;

namespace PrimeChecker
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            if (n == 0 || n == 1)
            {
                Console.WriteLine("false");
            }
            if (IsPrime(n))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
        static bool IsPrime (long num)
        {
            bool isValid = true;
            int counter = 2;
            while (counter <= Math.Sqrt(num))
            {
                if (num % counter == 0)
                {
                    isValid = false;
                    break;

                }
                counter++;
            }
            return isValid;
        }
    }
}
