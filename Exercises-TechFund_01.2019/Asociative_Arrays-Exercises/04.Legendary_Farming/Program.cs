using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Legendary_Farming             // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string[] inputLine = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> materials = new Dictionary<string, int>
            {
                { "fragments", 0 },
                { "shards", 0 },
                { "motes", 0 },
            };
           

            bool IsTheMarkReached = false;
            string item = "";
            int quantity = 0;

            while ( ! IsTheMarkReached)
            {
                
                for (int i = 1; i < inputLine.Length; i += 2)
                {
                    item = inputLine[i].ToLower();
                    quantity = int.Parse(inputLine[i - 1]);

                    if (materials.ContainsKey(item) == false)
                    {
                        materials.Add(item, 0);
                    }

                    materials[item] += quantity;

                    if (materials[item] >= 250
                        && (item == "motes" || item == "fragments" || item == "shards"))
                    {
                        IsTheMarkReached = true;
                        materials[item] -= 250;
                        break;
                    }
                }
                if (IsTheMarkReached)
                {
                    break;
                }
                inputLine = Console.ReadLine().Split().ToArray();
            }

            switch (item)
            {
                case "shards":
                    Console.WriteLine($"Shadowmourne obtained!");
                    break;

                case "fragments":
                    Console.WriteLine($"Valanyr obtained!");
                    break;

                case "motes":
                    Console.WriteLine($"Dragonwrath obtained!");
                    break;
            }

            foreach (var material in materials
                .Where(i => i.Key == "shards" || i.Key == "fragments" || i.Key == "motes")
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in materials
                .Where(i => i.Key != "shards" && i.Key != "fragments" && i.Key != "motes")
                .OrderBy(i => i.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}" );
            }
        }
    }
}
