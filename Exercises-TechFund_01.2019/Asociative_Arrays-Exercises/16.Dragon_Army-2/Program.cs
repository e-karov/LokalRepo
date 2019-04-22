using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.Dragon_Army_2             // 100 / 100
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, Dictionary<string, double>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string type = input[0];
                string name = input[1];
                double damage = 45;
                double health = 250;
                double armor = 10;

                if (int.TryParse(input[2], out  int tempDamage))
                {
                    damage = tempDamage;
                }
              
                if (int.TryParse(input[3], out int tempHealth))
                {
                    health = tempHealth;
                }

                if (int.TryParse(input[4], out int tempArmor))
                {
                    armor = tempArmor;
                }

                if (dragons.ContainsKey(type) == false)
                {
                    dragons.Add(type, new SortedDictionary<string, Dictionary<string, double>>());
                }

                if (dragons[type].ContainsKey(name) == false)
                {
                    dragons[type].Add(name, new Dictionary<string, double>());
                    dragons[type][name].Add("damage", damage);
                    dragons[type][name].Add("health", health);
                    dragons[type][name].Add("armor", armor);
                }
                else
                {
                    dragons[type][name]["damage"] = damage;
                    dragons[type][name]["health"] = health;
                    dragons[type][name]["armor"] = armor;
                }
            }

            foreach (var item in dragons)
            {
                double avDamage = GetAverageValue(item, "damage");
                double avHealth = GetAverageValue(item, "health");
                double avAromor = GetAverageValue(item, "armor");

                Console.WriteLine($"{item.Key}::({avDamage:F2}/{avHealth:F2}/{avAromor:F2})");

                foreach (var dragon in item.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value["damage"]}," +
                        $" health: {dragon.Value["health"]}, armor: {dragon.Value["armor"]}");
                }
            }
        }

        static double GetAverageValue(KeyValuePair<string, SortedDictionary<string, Dictionary<string, double>>> dict, string nameStr)
        {
            double averageValue = dict.Value
                .SelectMany(x => x.Value.Where(v => v.Key == nameStr))
                .ToArray()
                .Average(x => x.Value);

            return averageValue;

        }
    }
}
