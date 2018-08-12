using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (c > GetMax(a, b))
            {
                Console.WriteLine(c);

            }
            else
            {
                Console.WriteLine(GetMax(a, b));
            }

        }
        static int GetMax (int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
