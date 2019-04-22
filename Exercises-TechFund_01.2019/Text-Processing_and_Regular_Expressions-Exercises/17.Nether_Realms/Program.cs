using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _17.Nether_Realms                 // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string healthPattern = @"([^\d-\.\*\/\+ ])";
            string numberPattern = @"[-+]?[0-9]+(\.[0-9]+)?";

            var demons = new SortedDictionary<string, Dictionary<string, double>>();

            for (int i = 0; i < input.Length; i++)
            {
                string name = input[i];
                int health = 0;
                double damage = 0;
                MatchCollection healthMatches = Regex.Matches(name, healthPattern);

                foreach (Match match in healthMatches)
                {
                    char ch = char.Parse(match.Groups[1].Value);
                    health += (int)ch;
                }

                MatchCollection damageMatches = Regex.Matches(name, numberPattern);

                foreach (Match match in damageMatches)
                {
                    damage += double.Parse(match.Value);
                }
                MatchCollection modifierMattches = Regex.Matches(name, @"(\*)|(\/)");

                foreach (Match match in modifierMattches)
                {
                    if (match.Value == "*")
                    {
                        damage *= 2;
                    }

                    if (match.Value == "/")
                    {
                        damage /= 2;
                    }
                }

                if (demons.ContainsKey(name) == false)
                {
                    demons.Add(name, new Dictionary<string, double>());
                }

                demons[name].Add("health", health);
                demons[name].Add("damage", damage);
            }

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value["health"]} health, {demon.Value["damage"]:F2} damage");
            }
        }
    }
}
