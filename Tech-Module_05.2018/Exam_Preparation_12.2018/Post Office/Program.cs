using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Post_Office
{
    class Program
    {
        static void Main()
        {
            string firstPattern = @"(#|\$|%|\*|&+)(?<caps>[A-Z]+)(\1)";
            string secondPattern = @"(\d{2}):(\d{2})";
            string[] input = Console.ReadLine().Split('|');

            Match capsMatch = Regex.Match(input[0], firstPattern);
            char[] caps = capsMatch.Groups["caps"].Value.ToArray();

            MatchCollection matches = Regex.Matches(input[1], secondPattern);

            List<char> capLetters = new List<char>();
            List<int> wordLengths = new List<int>();

            foreach (Match match in matches)
            {
                capLetters.Add((char)int.Parse(match.Groups[1].Value));
                wordLengths.Add((char)int.Parse(match.Groups[2].Value));
            }

            string[] words = input[2].Split();

            for (int i = 0; i < capLetters.Count; i++)
            {
                foreach (var word in words)
                {
                    if (word.Length == wordLengths[i] + 1 && word[0] == capLetters[i])
                    {

                        Console.WriteLine(word);
                        break;
                    }
                }
            }
        }
    }
}
