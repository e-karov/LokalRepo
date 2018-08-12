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
                Console.WriteLine("False");
                Environment.Exit(0);
            }
            if (IsPrime(n))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
        static bool IsPrime (long num)
        {
            bool isValid = true;
            int divider = 2;
            while (divider <= Math.Sqrt(num))
            {
                if (num % divider == 0)
                {
                    isValid = false;
                    break;

                }
                divider++;
            }
            return isValid;
        }
    }
}
