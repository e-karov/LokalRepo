using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.Star_Enigma                   // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
           
            string countPattern = @"[starSTAR]";
            string message = "";
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection keyMatches = Regex.Matches(input, countPattern);
                int key = keyMatches.Count;
                StringBuilder encrypted = new StringBuilder();

                for (int k = 0; k < input.Length; k++)
                {
                    encrypted.Append((char)(input[k] - key));
                }
                message = encrypted.ToString();


                string messagePattern = @"@(?<planet>[A-Za-z]+)([^!:\->@]*):(?<pop>[\d]+)([^@:\->!]*)!(?<type>[A,D])!([^@:->!]*)->(?<soldierCount>[\d]+)";
                MatchCollection matches = Regex.Matches(message, messagePattern);

                foreach (Match match in matches)
                {
                    if (match.Groups["type"].Value == "A")
                    {
                        attackedPlanets.Add(match.Groups["planet"].Value);
                    }

                    else if (match.Groups["type"].Value == "D")
                    {
                        destroyedPlanets.Add(match.Groups["planet"].Value);
                    }

                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
