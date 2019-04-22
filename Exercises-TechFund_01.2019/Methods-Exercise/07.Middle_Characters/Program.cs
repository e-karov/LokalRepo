using System;

namespace _07.Middle_Characters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            PrintMiddleChars(input);
        }

        static void PrintMiddleChars(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Length % 2 == 0)
                {
                    if (i == str.Length /2 -1 || i == str.Length / 2)
                    {
                        Console.Write(str[i]);
                    }
                }
                else
                {
                    if (i == str.Length / 2)
                    {
                        Console.Write(str[i]);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
