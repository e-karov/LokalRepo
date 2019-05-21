using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Iron_Girder
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, int> townsAndTimes = new SortedDictionary<string, int>();
            SortedDictionary<string, int> townsAndPassengers = new SortedDictionary<string, int>();

            string pattern = @"^([a-zA-Z-]+):(\d+)->(\d+)$";
            string ambushPattern = @"^([a-zA-Z-]+):([ambush]+)->(\d+)$";

            string input = "";

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Slide rule")
                {
                    break;
                }

                Match match = Regex.Match(input, pattern);
                Match ambush = Regex.Match(input, ambushPattern);

                if (ambush.Success)
                {
                    string town = ambush.Groups[1].Value;
                    int passengersCount = int.Parse(ambush.Groups[3].Value);


                    if (townsAndTimes.ContainsKey(town))
                    {
                        townsAndTimes[town] = 0;
                        townsAndPassengers[town] -= passengersCount;
                    }
                    else
                    {

                        continue;
                    }

                }

                else if (match.Success)
                {
                    string town = match.Groups[1].Value;
                    int passengersCount = int.Parse(match.Groups[3].Value);
                    int time = int.Parse(match.Groups[2].Value);


                    if (townsAndPassengers.ContainsKey(town) == false)
                    {
                        townsAndPassengers.Add(town, 0);
                        townsAndTimes.Add(town, 0);

                    }

                    townsAndPassengers[town] += passengersCount;

                    if (townsAndTimes[town] == 0)
                    {
                        townsAndTimes[town] = time;
                    }
                    else if (townsAndTimes[town] > time)
                    {
                        townsAndTimes[town] = time;
                    }
                }

            }


            townsAndTimes.Where(x => x.Value > 0 && townsAndPassengers[x.Key] > 0).OrderBy(x =>x.Value).ThenByDescending(x => townsAndPassengers[x.Key]).ToDictionary(x => x.Key, x => x.Value).ToList().
               ForEach(y =>
           {
               Console.WriteLine($"{y.Key } -> Time: {y.Value} -> Passengers: {townsAndPassengers[y.Key]}");
           });
        }
    }
}
