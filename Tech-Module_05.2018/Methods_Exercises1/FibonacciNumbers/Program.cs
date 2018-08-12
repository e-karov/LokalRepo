using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n));
        }

        static int GetFibonacci(int num)
        {

            int a = 1;
            int b = 1;
            int c = 0;

            if (num == 0 || num == 1)
            {
                c = 1;
            }

            for (int i = 2; i < num; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
