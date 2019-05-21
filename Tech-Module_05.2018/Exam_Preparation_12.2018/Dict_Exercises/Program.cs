using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Dict_Exercises
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                string[] inputArr = inputLine.Split();

                Match regMatch = Regex.Match(inputLine, @"^(register)\s([a-zA-Z0-9]+)\b\s\b([A-Z]{2}\d{4}[A-Z]{2})$");
                Match plateMatch = Regex.Match(inputLine, @"\b([A-Z]{2})(\d{4})([A-Z]{2})\b");
                Match unregMatch = Regex.Match(inputLine, @"^(unregister)\s(\w+)$");

                if (inputArr[0] == "register")
                {

                    if (plateMatch.Success == false)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {inputArr[2]}");

                    }
                    if (regMatch.Success)
                    {
                        string user = regMatch.Groups[2].Value;
                        string plate = regMatch.Groups[3].Value;

                        if (users.ContainsKey(user) == false)
                        {
                            if (users.ContainsValue(plate) == false)
                            {
                                users.Add(user, plate);

                                Console.WriteLine($"{user} registered {plate} successfully");
                            }
                            else if (users.ContainsValue(plate))
                            {
                                Console.WriteLine($"ERROR: license plate {plate} is busy");
                            }
                        }
                        else if (users.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {users[user]}");
                        }
                    }
                }

                else
                {
                    if (unregMatch.Success)
                    {
                        string user = unregMatch.Groups[2].Value;

                        if (users.ContainsKey(user) == false)
                        {
                            Console.WriteLine($" ERROR: user {user} not found");
                        }
                        else
                        {
                            users.Remove(user);

                            Console.WriteLine($"user {user} unregistered successfully");
                        }
                    }
                }

            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }


        }
    }
}
