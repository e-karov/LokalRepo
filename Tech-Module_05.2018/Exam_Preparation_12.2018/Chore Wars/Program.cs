using System;
using System.Text.RegularExpressions;

namespace Chore_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string dishPattern = @"<([a-z0-9]+)>";
            string cleaningPattern = @"\[([A-Z0-9]+)\]";
            string laundryPattern = @"{(.+)}";
            string numPattern = @"(\d{1})";
            int totalTime = 0;
            int dishesTime = 0;
            int cleaningTime = 0;
            int laundryTime = 0;

            while (true)
            {
                if (input == "wife is happy")
                {
                    break;
                }

                

                
                Match dishesMatch = Regex.Match(input, dishPattern);

                if (dishesMatch.Success)
                {
                    MatchCollection matches = Regex.Matches(dishesMatch.Groups[1].Value, numPattern);
                    foreach (Match item in matches)
                    {
                        dishesTime += int.Parse(item.Groups[1].Value);
                    }
                    
                }

                Match cleaningMatch = Regex.Match(input, cleaningPattern);

                if (cleaningMatch.Success)
                {
                    MatchCollection matches = Regex.Matches(cleaningMatch.Groups[1].Value, numPattern);
                    foreach (Match item in matches)
                    {
                        cleaningTime += int.Parse(item.Groups[1].Value);
                    }
                    
                }

                Match laundryMatch = Regex.Match(input, laundryPattern);

                if (laundryMatch.Success)
                {
                    MatchCollection matches = Regex.Matches(laundryMatch.Groups[1].Value, numPattern);
                    foreach (Match item in matches)
                    {
                        laundryTime += int.Parse(item.Groups[1].Value);
                    }
                    
                }

                totalTime = dishesTime + cleaningTime + laundryTime;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Doing the dishes - {dishesTime} min.");
            Console.WriteLine($"Cleaning the house - {cleaningTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTime} min.");
            Console.WriteLine($"Total - {totalTime} min.");
        }


    }
}
