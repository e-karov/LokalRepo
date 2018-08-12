using System;
using System.Collections.Generic;
using System.Linq;

namespace Srpsko_Unleached
{
    class Program
    {
        static void Main()
        {

            Dictionary<string, Dictionary<string, int>> venues = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(" @");

                if (tokens.Length != 2)
                {
                    continue;
                }

                string singerName = tokens[0];

                string[] venueAndTickets = tokens[1].Split();

                if (venueAndTickets.Length < 3  )
                {
                    continue;
                }

                bool hasTicketCount = int.TryParse(venueAndTickets[venueAndTickets.Length - 1], out int ticketCount);
                bool hasTicketPrice = int.TryParse(venueAndTickets[venueAndTickets.Length - 2], out int ticketPrice);

                if (hasTicketCount == false || hasTicketPrice == false)
                {
                    continue;
                }

                string venueName = GetVenueName(venueAndTickets);

                if (venues.ContainsKey(venueName) == false;
                {
                    venues.Add(venueName, new Dictionary<string, int>());
                }
                if (venues[venueName].ContainsKey(singerName) == false);
                {
                    venues[venueName].Add(singerName, 0);
                }

                venues[venueName][singerName] += ticketCount * ticketPrice;

                foreach (var venue in venues)
                {
                    Console.WriteLine(venue.Key);

                    foreach (var singer in venue.Value.OrderByDescending(s => s.Value))
                    {
                        Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                    }
                }
            }
        }

        static string GetVenueName (string[] tokens)
        {
            string venueName = "";

            for (int i = 0; i < tokens.Length-2; i++)
            {
                venueName += tokens[i] + " ";
            }
            return venueName.TrimEnd()
;        }
    }
}
