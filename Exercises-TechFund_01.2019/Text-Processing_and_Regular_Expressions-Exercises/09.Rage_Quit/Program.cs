using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _09.Rage_Quit             // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string commonPattern = @"(?<str>[\D]+)(?<count>[\d]+)";

            MatchCollection commonMatches = Regex.Matches(input, commonPattern);
            StringBuilder sb = new StringBuilder();

            foreach (Match match in commonMatches)
            {
                string currentStr = match.Groups["str"].Value.ToUpper();
                int count = int.Parse(match.Groups["count"].Value);

                for (int i = 0; i < count; i++)
                {
                    sb.Append(currentStr);
                }
            }

            int symbolsCount = sb.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {symbolsCount}");
            Console.WriteLine(sb);
        }
    }
}
