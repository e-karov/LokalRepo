using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


namespace Snowwhite                         // 100 / 100
{
    class Program
    {
        static void Main()
        {
            List<Dwarf> dwarves = new List<Dwarf>();

            string inputLine = Console.ReadLine();

            while (true)
            {
                
                if (inputLine == "Once upon a time")
                {
                    break;
                }

                Match match = Regex.Match(inputLine, 
                    @"^(?<name>[^ <>:]+)\s?<:>\s?(?<hat>[^ <>:]+)\s?<:>\s?(?<phys>\d+)$");

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string hat = match.Groups["hat"].Value;
                    int physics = int.Parse(match.Groups["phys"].Value);

                   if (dwarves.Where(d => d.Name == name && d.Hat == hat).Count() > 0)
                    {
                        if (dwarves.FirstOrDefault(m => m.Name == name && m.Hat == hat).Physics < physics)
                        {
                            dwarves.FirstOrDefault(m => m.Name == name && m.Hat == hat).Physics = physics;
                        }
                    }

                    else
                    {
                        dwarves.Add(new Dwarf(name, hat, physics));
                    }
                }

                else
                {
                    continue;
                }

                inputLine = Console.ReadLine();
            }

            foreach (Dwarf dwarf in dwarves
                .OrderByDescending(m => m.Physics)
                .ThenByDescending(n => dwarves.Where(j =>j.Hat == n.Hat).Count()))
            {
                Console.WriteLine($"({dwarf.Hat}) {dwarf.Name} <-> {dwarf.Physics}");
            }

            

           
        }

         class Dwarf
        {
            public string Name { get; set; }
            public string Hat { get; set; }
            public int Physics { get; set; }
            public Dwarf (string name, string color, int physics)
            {
                this.Name = name;
                this.Hat = color;
                this.Physics = physics;
            }
        }

    }
}
