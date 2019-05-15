using System;
using System.Collections.Generic;
using System.Linq;

namespace International_SoftUniada              // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" -> ");
            var countriesParticipants = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "END")
            {
                string country = input[0];
                string participant = input[1];
                int points = int.Parse(input[2]);

                if (countriesParticipants.ContainsKey(country) == false)
                {
                    countriesParticipants.Add(country,new Dictionary<string, int>());
                }

                if (countriesParticipants[country].ContainsKey(participant) == false)
                {
                    countriesParticipants[country].Add(participant, 0);
                }

                countriesParticipants[country][participant] += points;

                input = Console.ReadLine().Split(" -> ");
            }

            foreach (var country in countriesParticipants.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key}: {country.Value.Values.Sum()}");

                foreach (var participant in country.Value)
                {
                    Console.WriteLine($" -- {participant.Key} -> {participant.Value}");
                }
            }
        }
    }
}
