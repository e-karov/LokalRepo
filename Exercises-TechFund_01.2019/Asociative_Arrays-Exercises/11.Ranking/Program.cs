using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Ranking                       // 100 / 100
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();

            string input = "";
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] contestInfo = input.Split(":");

                string contest = contestInfo[0];
                string pass = contestInfo[1];

                if (contests.ContainsKey(contest) == false)
                {
                    contests.Add(contest, null);
                }
                contests[contest] = pass;
                
            }

            string submissionIput ;

            while ((submissionIput =Console.ReadLine()) != "end of submissions")
            {
                string[] submissionInfo = submissionIput.Split("=>");
                string contest = submissionInfo[0];
                string password = submissionInfo[1];
                string userName = submissionInfo[2];
                int points = int.Parse(submissionInfo[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (submissions.ContainsKey(userName) == false)
                    {
                        submissions.Add(userName, new Dictionary<string, int>());
                    }

                    if (submissions[userName].ContainsKey(contest) == false)
                    {
                        submissions[userName].Add(contest, 0);
                    }
                    if (submissions[userName][contest] < points)
                    {
                        submissions[userName][contest] = points;
                    }
                }
            }

            string bestUser = "";
            int bestPopints = 0;

            foreach (var item in submissions)
            {
                if (item.Value.Values.Sum() > bestPopints)
                {
                    bestPopints = item.Value.Values.Sum();
                    bestUser = item.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {bestPopints} points.");
            Console.WriteLine("Ranking:");

            foreach (var kvp in submissions.OrderBy(x => x.Key)) 
            {

                Console.WriteLine($"{kvp.Key}");

                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}