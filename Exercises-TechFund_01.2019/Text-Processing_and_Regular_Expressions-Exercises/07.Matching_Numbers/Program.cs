using System;
using System.Text.RegularExpressions;

namespace _07.Matching_Numbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(^|(?<=\s))-?(\d+)(\.\d+)?($|(?=\s))";

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match item in matches)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
