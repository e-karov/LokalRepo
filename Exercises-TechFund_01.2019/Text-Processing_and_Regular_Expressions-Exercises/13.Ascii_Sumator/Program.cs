using System;

namespace _13.Ascii_Sumator         //   100 / 100
{
    class Program
    {
        static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] > (int)start && input[i] < (int)end)
                {
                    sum += (int)input[i];
                }
                
            }

            Console.WriteLine(sum);
        }
    }
}
