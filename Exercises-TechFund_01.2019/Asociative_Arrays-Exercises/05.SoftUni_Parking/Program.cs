using System;
using System.Collections.Generic;

namespace _05.SoftUni_Parking           // 100/100
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> usersList = new Dictionary<string, string>();
            
            for (int i = 0; i < n; i++)
            {
                string[] commandLine = Console.ReadLine().Split();
                string command = commandLine[0].ToLower();
                string user = commandLine[1];
                

                switch (command)
                {
                    case "register":
                        string licencePlate = commandLine[2];

                        if (usersList.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number { usersList[user]}");
                        }

                        else if (usersList.ContainsKey(user) == false)
                        {
                            usersList.Add(user, licencePlate);

                            Console.WriteLine($"{user} registered {licencePlate} successfully");
                        }
                        break;

                    case "unregister":

                        if (usersList.ContainsKey(user) == false)
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }

                        else
                        {
                            usersList.Remove(user);
                            Console.WriteLine($"{user} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var user in usersList)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
