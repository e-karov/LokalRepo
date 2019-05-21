using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ForceSidesChanges
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            string forceSide = "";
            string user = "";

            while ((input = Console.ReadLine().Trim()) != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] commands = input.Split(" | ").ToArray();

                    forceSide = commands[0];
                    user = commands[commands.Length - 1];

                    if (sides.ContainsKey(forceSide) == false)
                    {
                        sides.Add(forceSide, new List<string>());
                    }


                    if (sides.Values.Any(x => x.Contains(user)) == false)
                    {
                        sides[forceSide].Add(user);
                    }
                }

                else if (input.Contains("->"))
                {
                    string[] commands = input.Split(" -> ").ToArray();

                    forceSide = commands[commands.Length - 1];
                    user = commands[0];


                    if (sides.Values.Any(x => x.Contains(user)) == false)
                    {
                        if (sides.ContainsKey(forceSide) == false)
                        {
                            sides.Add(forceSide, new List<string>());
                        }
                        sides[forceSide].Add(user);

                        Console.WriteLine($"{user} joins the {forceSide} side!");
                    }

                    else
                    {
                        sides.Values.First(x => x.Contains(user)).Remove(user);

                        if (sides.ContainsKey(forceSide) == false)
                        {
                            sides.Add(forceSide, new List<string>());
                        }

                        sides[forceSide].Add(user);

                        Console.WriteLine($"{user} joins the {forceSide} side!");
                    }


                }

            }

            foreach (var side in sides.OrderByDescending(side => side.Value.Count).ThenBy(side => side.Key))
            {
                if (side.Value.Count() > 0)
                {

                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                    foreach (string str in side.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {str}");
                    }
                }
            }
        }
    }

}

