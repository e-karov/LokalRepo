using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Concert               // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> bandsMembers = new Dictionary<string, List<string>>();
            SortedDictionary<string, int> bandsTimes = new SortedDictionary<string, int>();

            while (input != "start of concert")
            {
                string[] commandLine = input.Split("; ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandLine[0];
                string band = commandLine[1];
                

                switch (command)
                {
                    case "Add":
                        string[] members = commandLine[2]
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                        if (bandsMembers.ContainsKey(band) == false)
                        {
                            bandsMembers.Add(band, new List<string>());
                        }

                        foreach (var member in members)
                        {
                            if (bandsMembers[band].Contains(member) == false)
                            {
                                bandsMembers[band].Add(member);
                            }
                        }
                        break;


                    case "Play":
                        int time = int.Parse(commandLine[2]);

                        if (bandsTimes.ContainsKey(band) == false)
                        {
                            bandsTimes.Add(band, 0);
                        }

                        bandsTimes[band] += time;
                        break;
                }
                input = Console.ReadLine();
            }

            string bandName = Console.ReadLine();

            long totalTime = bandsTimes.Values.Sum(); 
            Console.WriteLine($"Total time: {totalTime}");

            foreach (var band in bandsTimes.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            Console.WriteLine(bandName);
            foreach (var member in bandsMembers[bandName])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
