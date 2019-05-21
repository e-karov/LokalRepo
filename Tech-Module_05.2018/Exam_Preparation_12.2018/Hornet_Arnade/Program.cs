using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hornet_Armade
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"^(\d+) = ([^=\-: >]+) -> ([^=\-:> ]+):(\d+)$");
            Dictionary<string, int> legions = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> soldiers = new Dictionary<string, Dictionary<string, long>>();
            string inputLine = "";

            for (int i = 0; i < n; i++)
            {
                inputLine = Console.ReadLine();

                Match match = regex.Match(inputLine);

                if (match.Success)
                {
                    int activity = int.Parse(match.Groups[1].Value);
                    string legion = match.Groups[2].Value;
                    string soldierType = match.Groups[3].Value;
                    long soldierCount = long.Parse(match.Groups[4].Value);

                    if (legions.ContainsKey(legion) == false)
                    {
                        legions.Add(legion, 0);
                        soldiers.Add(legion, new Dictionary<string, long>());
                    }

                    if (legions[legion] < activity)
                    {
                        legions[legion] = activity;
                    }
                    if (soldiers[legion].ContainsKey(soldierType) == false)
                    {
                        soldiers[legion].Add(soldierType, 0);
                    }
                    soldiers[legion][soldierType] += soldierCount;

                }
            }

            string command = Console.ReadLine();
            if (command.Contains('\\'))
            {
                int actitvitySearched = int.Parse(command.Split('\\')[0]);
                string soldierSearched = command.Split('\\')[1];

                soldiers.Where(x => legions[x.Key] < actitvitySearched && soldiers[x.Key].ContainsKey(soldierSearched))
                    .OrderByDescending(x => x.Value[soldierSearched])
                    .ToDictionary(x => x.Key, x => x.Value)
                    .ToList()
                    .ForEach(e =>
                    {
                        Console.WriteLine($"{e.Key} -> {e.Value[soldierSearched]}");
                    });
            }
            else
            {
                string soldierSearched = command;

                //legions.Where(x => soldiers[x.Key].ContainsKey(soldierSearched))
                //    .OrderByDescending(x => x.Value)
                //    .ToDictionary(x => x.Key, x => x.Value)
                //    .ToList()
                //    .ForEach(e =>
                //    {
                //        Console.WriteLine($"{e.Value} : {e.Key}");
                //    });

                foreach (var item in legions.OrderByDescending(x => x.Value))
                {
                    if (soldiers[item.Key].ContainsKey(soldierSearched))
                    {
                        Console.WriteLine($"{item.Value} : {item.Key}");
                    }
                }
            }

            
        }
    }
}
//          legions.Where(x => legionsActivities[x.Key] < activity
//                         && legions[x.Key].ContainsKey(soldier))
//                        .OrderByDescending(x => x.Value[soldier])
//                        .ToDictionary(k => k.Key, x => x.Value)
//                        .ToList()
//                        .ForEach(e =>

//                          {
//                              Console.WriteLine($"{e.Key} -> {e.Value[soldier]}");
//                          });
//                      }
//                //The other option to implement the sorting and printing:
//            
////        foreach (var item in legionsActivities.OrderByDescending(x => x.Value))
////                {
////                    if (legions[item.Key].ContainsKey(soldier))
////                        {
////                             Console.WriteLine($"{item.Value} : {item.Key}");
////                         }
////                 }