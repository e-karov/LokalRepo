using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Sort_Times
{
    class Program
    {
        static void Main()
        {
            List<KeyValuePair<int, int>> times = new List<KeyValuePair<int, int>>();

            string[] input = Console.ReadLine().Split();

            foreach (var item in input)
            {
                string current = item.Split(":").ToString();
                int hour = int.Parse(current[0].ToString());
                int min = int.Parse(current[1].ToString());
                times.Add(new KeyValuePair<int, int>(hour, min));

            }
            times.OrderBy(t => t.Key).ThenBy(t => t.Value);
            Console.WriteLine(string.Join(", ", times));



        }
    }
}
