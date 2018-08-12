using System;

namespace HelloName
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine( Math.Max(a, GetMax(b,c)));
        }

        static int GetMax (int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            return second;
        }
    }
}
