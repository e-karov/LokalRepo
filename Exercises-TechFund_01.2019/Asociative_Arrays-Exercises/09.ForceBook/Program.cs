using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook                 // 90 /100
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            while (input != "Lumpawaroo")
            {
                string[] inputLine;

                if (input.Contains(" | "))
                {
                    inputLine = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string side = inputLine[0];
                    string user = inputLine[1];

                    if (sides.ContainsKey(side) == false)
                    {
                        sides.Add(side, new List<string>());
                    }

                    if (sides[side].Contains(user) == false)
                    {
                        sides[side].Add(user);
                    }
                }

                else if (input.Contains(" -> "))
                {
                    inputLine = input.Split(" -> ").ToArray();
                    string user = inputLine[0];
                    string side = inputLine[1];

                    foreach (var kvp in sides)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            kvp.Value.Remove(user);
                        }
                    };

                    if (sides.ContainsKey(side) == false)
                    {
                        sides.Add(side, new List<string>());
                    }

                    sides[side].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }

                input = Console.ReadLine();
            }

            sides = sides
                .Where(s => s.Value.Count > 0)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var side in sides.OrderByDescending(s => s.Value.Count()).ThenBy(s => s.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count()}");

                foreach (var user in side.Value.OrderBy(u => u))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }

    }
}
