using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.Dragon_Army
{
    class Program
    {
        static void Main()
        {
            List<Dragon> dragons = new List<Dragon>();
            int n = int.Parse(Console.ReadLine());
            // {type} {name} {damage} {health} {armor}

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string type = input[0];
                string name = input[1];
                double damage = 0;
                double health = 0;
                double armor = 0;

                Dragon drago = new Dragon
                {
                    Name = name,
                    Type = type,
                    
                };

                if (input[2] != "null")
                {
                    damage = double.Parse(input[2]);
                    drago.Damage = damage;
                }
                if (input[3] != "null")
                {
                    health = double.Parse(input[3]);
                    drago.Health = health;
                }
                if (input[4] != "null")
                {
                    armor = double.Parse(input[4]);
                    drago.Armor = armor;
                }

                if (dragons.Where(d => d.Name == name && d.Type == type).Count() > 0)
                {
                    dragons.FirstOrDefault(d => d.Name == name && d.Type == type).Damage = damage;
                    dragons.FirstOrDefault(d => d.Name == name && d.Type == type).Health = health;
                    dragons.FirstOrDefault(d => d.Name == name && d.Type == type).Armor = armor;
                }
                else
                {
                    dragons.Add(drago);
                }
            }

           

            foreach (var dragon in dragons.Where(d => d.Type == d.Type))
            {
               
            }

        }
    }

    class Dragon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Damage { get; set; } = 45;
        public double Health { get; set; } = 250;
        public double Armor { get; set; } = 10;

        public Dragon()
        {
            this.Armor = 10;
            this.Damage = 45;
            this.Health = 250;
        }
        
    }
}
