using System;

namespace _6.Messages
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string message = "";

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    message += " ";
                    continue;
                }

                int digit = input % 10;
                int length = input.ToString().Length;
                int offset = (digit - 2) * 3;

                if (digit == 8 || digit == 9)
                {
                    offset = ((digit - 2) * 3) + 1;
                }

                int lettersPsition= (offset + length - 1);
                message += (char)(97 + lettersPsition);

            }

            Console.WriteLine(message);

        }
    }
}
