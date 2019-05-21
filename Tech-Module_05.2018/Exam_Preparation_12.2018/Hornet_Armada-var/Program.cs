    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hornet_Armada
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = "";

            Dictionary<string, int> legionsActivities = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> legions = new Dictionary<string, Dictionary<string, long>>();


            for (int i = 0; i < n + 1; i++)
            {
                input = Console.ReadLine();
                Match commandMatch = Regex.Match(input, @"^(?<act>\d*)\\*(?<st>[a-zA-Z]+)$");
                Match dataMatch = Regex.Match(input, @"^(?<act>\d+) = (?<leg>[^=\-:> ]*) -> (?<type>[^=\-:> ]*):(?<count>\d+)");

                if (dataMatch.Success)
                {

                    int lastActivity = (int.Parse(dataMatch.Groups["act"].Value));
                    string legionName = dataMatch.Groups["leg"].Value;
                    string soldierType = dataMatch.Groups["type"].Value;
                    long soldierCount = long.Parse(dataMatch.Groups["count"].Value);

                    if (legions.ContainsKey(legionName) == false)
                    {
                        legions.Add(legionName, new Dictionary<string, long>());
                        legionsActivities.Add(legionName, lastActivity);

                    }
                    if (legions[legionName].ContainsKey(soldierType) == false)
                    {
                        legions[legionName].Add(soldierType, 0);
                    }

                    legions[legionName][soldierType] += soldierCount;

                    if (legionsActivities[legionName] < lastActivity)
                    {
                        legionsActivities[legionName] = lastActivity;
                    }
                }
                if (input.Contains("\\"))
                {
                    int activity = int.Parse(input.Substring(0, input.IndexOf("\\")));
                    string soldier = input.Substring(input.IndexOf("\\") + 1);
                    //The functional option to sort the collection:

                    legions.Where(x => legionsActivities[x.Key] < activity
                         && legions[x.Key].ContainsKey(soldier))
                        .OrderByDescending(x => x.Value[soldier])
                        .ToDictionary(k => k.Key, x => x.Value)
                        .ToList()
                        .ForEach(e =>

                        {
                            Console.WriteLine($"{e.Key} -> {e.Value[soldier]}");
                        });
                }
                //The other option to implement the sorting and printing:
                else
                {
                    string soldier = input;

                    //foreach (var item in legionsActivities.OrderByDescending(x => x.Value))
                    //{
                    //    if (legions[item.Key].ContainsKey(soldier))
                    //    {
                    //        Console.WriteLine($"{item.Value} : {item.Key}");
                    //    }
                    // }
                    legionsActivities.OrderByDescending(x => x.Value)
                         .ToDictionary(x => x.Key, v => v.Value)
                         .ToList()
                         .ForEach(e =>
                         {
                             if (legions[e.Key].ContainsKey(soldier))   
                             {
                                 Console.WriteLine($"{e.Value} : {e.Key}");
                             }
                         });
                }

            }
        }
    }
}
