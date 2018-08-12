using System;
using System.Collections.Generic;

namespace AMinorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(line))
                {
                    dict.Add(line, quantity);
                }
                else
                {
                    dict[line] += quantity;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} ->){item.Value}");
            }
        }
    }
}
