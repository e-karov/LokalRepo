using System;

namespace _01.Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            PrintTheSmallestNumber(num1, num2, num3);
        }

        private static void PrintTheSmallestNumber(int a, int b, int c)
        {
            if (a <= b && a <= c)
            {
                Console.WriteLine(a);
            }
            else if (b <= a && b <= c)
            {
                Console.WriteLine(b);
            }

            else if (c <= a && c <= b)
            {
                Console.WriteLine(c);
            }
        }
    }
}
