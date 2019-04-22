using System;

namespace _10.Palindrome_Numbers
{
    class Program
    {
        static void Main()
        {
            string input = "";

            while ((input = Console.ReadLine()) != "END")
            {
                if (IsPalindrom(input))
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static bool IsPalindrom(string input)
        {
            bool isPalindrom = true;

            for (int i = 0; i < input.Length / 2; i++)
            {

                if (input[i] != input[input.Length - 1 - i])
                {
                    isPalindrom = false;
                    break;
                }
            }
            return isPalindrom;
        }
    }
}
