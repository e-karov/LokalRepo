using System;

namespace GetMaxMeth
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int max = GetMax(first, second);
            max = GetMax(max, third);

            Console.WriteLine(max);
        }

        static int GetMax ( int a, int b)
        {
            int max = 0;
            if (a > b)
            {
                max = a;
            }

            else
            {
                max = b;
            }
            return max;
        }
    }
}
