using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.Snowwhite             // 100 / 100
{
    class Program
    {
        static void Main()
        {
            var dwarves = new Dictionary<string, Dictionary<string, int>>();
            string input = "";
            //List<Dwarf> dwarves = new List<Dwarf>();

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] inputLine = input.Split(" <:> ");
                string name = inputLine[0];
                string color = inputLine[1];
                int physics = int.Parse(inputLine[2]);

                //Dwarf dwarf = new Dwarf
                //{
                //    Name = name,
                //    HatColor = color,
                //    Physics = physics,

                //};

                //if (dwarves.Where(d => d.Name == name && d.HatColor == color).Count() == 0)
                //{
                //    dwarves.Add(dwarf);
                //}

                //else if (dwarves.FirstOrDefault(d => d.Name == name && d.HatColor == color).Physics < physics)
                //{
                //    dwarves.FirstOrDefault(d => d.Name == name && d.HatColor == color).Physics = physics;
                //}

                if (dwarves.ContainsKey(color) == false)
                {
                    dwarves.Add(color, new Dictionary<string, int>());
                }
                if (dwarves[color].ContainsKey(name) == false)
                {
                    dwarves[color].Add(name, 0);
                }
                if (dwarves[color][name] < physics)
                {
                    dwarves[color][name] = physics;
                }
            }

            foreach (var item in dwarves.OrderByDescending(y => y.Value.Values.Max()).ThenByDescending(c => c.Value.Count()))
                {

                    foreach (var kvp in item.Value)
                    {
                        Console.WriteLine($"({item.Key}) {kvp.Key} <-> {kvp.Value}");
                    }
                }
            
            //foreach (var dwarf in dwarves.OrderByDescending(d => d.Physics)
            //    .ThenByDescending(d => dwarves.Where(x => x.HatColor == d.HatColor)
            //    .Count()))
            //{
            //    Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            //}
        }
    }

    //class Dwarf
    //{
    //    public Dwarf()
    //    {
    //        List<Dwarf> dwarves = new List<Dwarf>();
    //    }

    //    public string Name { get; set; }
    //    public string HatColor { get; set; }
    //    public int Physics { get; set; }
    //}
}
