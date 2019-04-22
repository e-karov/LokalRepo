using System;
using System.Text.RegularExpressions;

namespace _06.Replace_Repeating_Chars
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string pattern = @"(.)\1{1,}";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                text = text.Replace(match.Groups[0].Value, match.Groups[1].Value);
            }

            Console.WriteLine(text);
        }
    }
}
