using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine(  FindPrimesInRange(start, end));
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            string result = "";
            bool isPrime = true;
            int divider = 2;
            for (int i = startNum; i <= endNum; i++)
            {
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
                    result += "i";
                }
                
            }
            List<int> numbers = new List<int>(Array.ConvertAll(result.Split(','), int.Parse));
            return numbers;

        }
    }
}
