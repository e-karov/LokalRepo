using System;

namespace _02.Vowels_Count
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            PrintVowelsCount(input);
        }

        static void PrintVowelsCount(string input)
        {
            int vowelsCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] == 65 || (int)input[i] == 69
                    || (int)input[i] == 73 || (int)input[i] == 79 || (int)input[i] == 85
                    || (int)input[i] == 97 || (int)input[i] == 101 || (int)input[i] == 105
                    || (int)input[i] == 111 || (int)input[i] == 117)
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);
        }
    }
}
