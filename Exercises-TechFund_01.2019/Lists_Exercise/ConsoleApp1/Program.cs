using System;
using System.Collections.Generic;
using System.Linq;

namespace Train             // 100/100
{
    class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string[] inputLine = Console.ReadLine().Split();
            

            while (inputLine[0] != "end")
            {
                if (inputLine[0] == "Add")
                {
                    int passengers = int.Parse(inputLine[1]);
                    wagons.Add(passengers);
                }
                else 
                {
                    int passengers = int.Parse(inputLine[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= capacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                inputLine = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
