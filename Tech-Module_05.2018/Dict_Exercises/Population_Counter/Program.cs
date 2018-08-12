using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> totalPopulation = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> countriesAndCities = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string inputStr = Console.ReadLine();

                if (inputStr == "report")
                {
                    break;
                }

                string[] input = inputStr.Split("|");
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);

                if (totalPopulation.ContainsKey(country) == false) 
                {
                    totalPopulation.Add(country, 0);
                    countriesAndCities.Add(country, new Dictionary<string, long>());
                }

                totalPopulation[country] += population;
                countriesAndCities[country].Add(city, population);

            }

            foreach (var country in totalPopulation.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");

                Dictionary<string, long> cities = countriesAndCities[country.Key]
                    .OrderByDescending(c => c.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key }: {city.Value}");
                }
            }

        }
    }
}
