using System;

namespace _6.Strong_Number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number == FactorialsSum(number))
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }

        static  int FactorialsSum (int num)
        {
           
            int factorialsSum = 0;

            while (num > 0)
            {
                int factorial = 1;
                int lastDigit = num % 10;

                for (int i = lastDigit; i > 0; i--)
                {
                    factorial *= i;
                }

                factorialsSum += factorial;
                num /= 10;
            }

            return factorialsSum;
        }
    }
}
