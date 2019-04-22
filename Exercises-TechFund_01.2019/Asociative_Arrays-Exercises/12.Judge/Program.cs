using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Judge
{
    class Program
    {
        static void Main()
        {
            var contests = new Dictionary<string, SortedDictionary<string, int>>();
            var usersList = new Dictionary<string, Dictionary<string, int>>();
            string input = "";

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] inputLine = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string userName = inputLine[0];
                string contest = inputLine[1];
                int points = int.Parse(inputLine[2]);

                if (contests.ContainsKey(contest) == false)
                {
                    contests.Add(contest, new SortedDictionary<string, int>());
                }

                if (contests[contest].ContainsKey(userName) == false)
                {
                    contests[contest].Add(userName, 0);
                }
                
                if (contests[contest][userName] < points)
                {
                    contests[contest][userName] = points;
                }

                if (usersList.ContainsKey(userName) == false)
                {
                    usersList.Add(userName, new Dictionary<string, int>());
                }

                if (usersList[userName].ContainsKey(contest)  == false)
                {
                    usersList[userName].Add(contest, points);
                }

                if (usersList[userName][contest] < points)
                {
                    usersList[userName][contest] = points;
                }

            }


            foreach (var contest in contests)
            {
                int position = 1;
                Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");

                foreach (var item in contest.Value.OrderByDescending(i => i.Value))
                {
                    Console.WriteLine($"{position++}. {item.Key} <::> {item.Value}");
                }
            }

            Console.WriteLine("Individual standings:");

            int counter = 1;
            foreach (var item in usersList.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{counter++}. {item.Key} -> {item.Value.Values.Sum()}");
            }
        }
    }
}
