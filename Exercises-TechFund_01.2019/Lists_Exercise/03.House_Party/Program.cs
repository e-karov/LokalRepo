using System;
using System.Collections.Generic;

namespace _03.House_Party           // 100/100
{
    class Program
    {
        static void Main()
        {
            List<string> guestList = new List<string>();
            int guestCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < guestCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];

                if (input.Length == 3)
                {
                    if (guestList.Contains(name) == false)
                    {
                        guestList.Add(name);
                    }
                    else if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                 
                }

                else if (input.Length == 4)
                {
                    if (guestList.Contains(name) )
                    {
                        guestList.Remove(name);
                    }

                    else if (guestList.Contains(name) == false)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join("\n", guestList));
        }
    }
}
