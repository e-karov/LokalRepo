using System;

namespace _05.Add_And_Subtract
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(SumAndSubtract(a, b ,c));
        }

        static int Sum(int a, int b)
        {
            int sum = a + b;

            return sum;
        }

        static int Subtract(int a, int b, int c)
        {
            int result = Sum(a, b) - c;
            return result;
        }

        static int SumAndSubtract(int a, int b, int c)
        {
            int endReslut = Subtract(a, b, c);
            return endReslut;
        }
    }
}
