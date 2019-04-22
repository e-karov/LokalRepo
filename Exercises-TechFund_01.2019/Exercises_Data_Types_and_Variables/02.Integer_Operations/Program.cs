using System;

namespace _02.Integer_Operations
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            long sum = num1 + num2;
            long div = sum / num3;
            long product = div * num4;

            Console.WriteLine(product);
        }
    }
}
