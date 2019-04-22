using System;

namespace _03.Tribonacci_Sequence
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            PrintTribonacciNumbers(num);

        }

        static void PrintTribonacciNumbers(int num)
        {
            int[] tribNums = new int[num];

            tribNums[0] = 1;
            if (num > 1)
            {
                tribNums[1] = 1;
            }

            if (num >2)
            {
                tribNums[2] = 2;
            }

            for (int i = 3; i < num; i++)
            {
                tribNums[i] = tribNums[i-3] + tribNums[i - 2] + tribNums[i - 1];
            }

            Console.Write(String.Join(' ', tribNums));
            Console.WriteLine();
        }
    }
}
