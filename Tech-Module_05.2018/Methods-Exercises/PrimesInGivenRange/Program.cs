using System;
using System.Collections.Generic;

namespace Temp_14._07._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());


            PrintPrimesList(FindPrimesInRange(startNum, endNum));

        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> PrimeNumbers = new List<int>();


            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                int divider = 2;
                if (i == 0 || i == 1)
                {
                    isPrime = false;

                }

                while (divider <= Math.Sqrt(i))
                {

                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    divider++;
                }
                if (isPrime)
                {
                    PrimeNumbers.Add(i);
                }

            }
            return PrimeNumbers;

        }

        static void PrintPrimesList(List<int> primesList)
        {
            Console.WriteLine(string.Join(", ", primesList));
        }



    }
}
