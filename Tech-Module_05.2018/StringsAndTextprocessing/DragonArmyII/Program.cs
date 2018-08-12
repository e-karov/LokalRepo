using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmyII
{
    class Program
    {
        static void Main()
        {

            Dictionary<string, SortedDictionary<string, Dragon>> army = 
                new Dictionary<string, SortedDictionary<string, Dragon>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] data = input.Split();

                string type = data[0];
                string name = data[1];
               string damageStr =(data[2]);
               string healthStr =(data[3]);
               string armorStr = (data[4]);

                int damage;
                try
                {
                    damage = int.Parse(damageStr);
                }
                catch (Exception)
                {

                    damage = 45;
                }

                if (int.TryParse(healthStr, out int health) == false)
                {
                    health = 250;
                }

                int armor = armorStr == "null" ? 10 : int.Parse(armorStr);

                Dragon dragon = new Dragon()
                {
                    Name = name,
                    Damage = damage,
                    Health = health,
                    Armor = armor
                };

                if (army.ContainsKey(type) == false)
                {
                    army.Add(type, new SortedDictionary<string, Dragon>());
                }

                army[type][dragon.Name] = dragon;
            }

            foreach (var type in army)
            {
                var damageAv = type.Value.Select(d => d.Value.Damage).Average();
                var healthAv = type.Value.Select(d => d.Value.Health).Average();
                var armorAv = type.Value.Select(d => d.Value.Armor).Average();

                Console.WriteLine($"{type.Key}::({damageAv:f2}/{healthAv:f2}/{armorAv:f2})");

                foreach (var d in type.Value.OrderBy(d => d.Key))
                {
                    Console.WriteLine($"-{d.Key} -> damage: {d.Value.Damage}, health: {d.Value.Health}, armor: {d.Value.Armor}");
                }
            }
        }
    }

    class Dragon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
}
