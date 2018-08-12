using System;

namespace Loops
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
            }
        }
    }
}
