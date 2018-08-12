using System;

namespace Ternary_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            string result = a % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(result);
        }
    }
}
