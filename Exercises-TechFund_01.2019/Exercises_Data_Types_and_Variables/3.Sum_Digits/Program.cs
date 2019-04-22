using System;

namespace _3.Sum_Digits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
