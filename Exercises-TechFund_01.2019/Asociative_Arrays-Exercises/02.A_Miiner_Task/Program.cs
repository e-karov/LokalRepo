using System;
using System.Collections.Generic;

namespace _02.A_Miiner_Task
{
    class Program
    {
        static void Main()
        {
            string input;
            Dictionary<string, double> resources = new Dictionary<string, double>();

            while ((input = Console.ReadLine()) != "stop")
            {
                string resource = input;
                double quantity = double.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource) == false)
                {
                    resources.Add(resource, 0);
                }

                resources[resource] += quantity;
            }

            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
