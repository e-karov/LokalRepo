using System;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else if (n == 1)
            {
                Console.WriteLine(1);
            }
            
            else
            {
                Console.WriteLine(GetFibonacci(n));
            }
        }

        static int GetFibonacci (int n)
        {
            int a = 1;
            int b = 1;
            int c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
