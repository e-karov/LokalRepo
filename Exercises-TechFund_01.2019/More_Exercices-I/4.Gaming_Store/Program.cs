using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Gaming_Store
{
    class Program
    {
        static void Main()
        {

            double budget = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            double price = 0;
            double totalSpent = 0;

            while (input != "Game Time")
            {
                switch (input)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;

                    case "CS: OG":
                        price = 15.99;
                        break;

                    case "Zplinter Zell":
                        price = 19.99;
                        break;

                    case "Honored 2":
                        price = 59.99;
                        break;

                    case "RoverWatch":
                        price = 29.99;
                        break;

                    default:
                        Console.WriteLine("Not found");
                        input = Console.ReadLine();

                        continue;
                        
                }

                if (budget >= price)
                {
                    budget -= price;
                    totalSpent += price;

                    Console.WriteLine($"Bought {input}");

                    if (budget <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${budget:F2}");




            //Dictionary<string, double> games = new Dictionary<string, double>();

            //games.Add("OutFall 4", 39.99);
            //games.Add("CS: OG", 15.99);
            //games.Add("Zplinter Zell", 19.99);
            //games.Add("Honored 2", 59.99);
            //games.Add("RoverWatch", 29.99);
            //games.Add("RoverWatch Origins Edition", 39.99);

            //double budget = double.Parse(Console.ReadLine());

            //string input = Console.ReadLine();
            //double totalSpent = 0;

            //while (input != "Game Time")
            //{
            //    if (games.ContainsKey(input))
            //    {
            //        if (budget >= games[input])
            //        {
            //            Console.WriteLine($"Bought {input}");

            //            totalSpent += games[input];
            //            budget -= games[input];

            //            if (budget <= 0)
            //            {
            //                Console.WriteLine("Out of money!");
            //                Environment.Exit(0);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Too Expensive");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Found");
            //    }

            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"Total spent: ${totalSpent:F}. Remaining: ${budget:F2}" );
        }
    }
}
