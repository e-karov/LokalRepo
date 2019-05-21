using System;
using System.Collections.Generic;
using System.Linq;

namespace SuftUni_Karaoke
{
    class Program
    {
        static void Main()
        {
            List<string> participants = Console.ReadLine()
                .Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToList();

            List<string> songList = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToList();

            SortedDictionary<string, List<string>> awardRegister = new SortedDictionary<string, List<string>>();

            string inputLine = "";

            while ((inputLine = Console.ReadLine()) != "dawn")
            {
                string[] contest = inputLine
                    .Split(new [] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(e => e.Trim())
                    .ToArray();

                string participant = contest[0];
                string song = contest[1];
                string award = contest[2];

                if (songList.Contains(song) && participants.Contains(participant))
                {
                    if (awardRegister.ContainsKey(participant) == false)
                    {
                        awardRegister.Add(participant, new List<string>());

                    }

                    if (awardRegister[participant].Contains(award))
                    {
                        continue;
                    }
                    else
                    {
                        awardRegister[participant].Add(award);
                    }
                }
            }

            if (awardRegister.Count() == 0)
            {
                Console.WriteLine("No awards");
            }

            foreach (var pair in awardRegister.OrderByDescending(x => x.Value.Count))
            {
                if (pair.Value.Count() == 0)
                {
                    Console.WriteLine("No awards");
                }

                else
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value.Count()} awards");

                    foreach (var award in pair.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($" --{award}");
                    }
                }
            }
        }
    }
}
