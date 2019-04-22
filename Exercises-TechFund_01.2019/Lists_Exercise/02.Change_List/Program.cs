using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List           // 100/100
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] inputLine = Console.ReadLine().Split();

            while (inputLine[0] != "end")
            {
                switch (inputLine[0])
                {
                    case "Delete":
                        int value = int.Parse(inputLine[1]);

                        numbers.RemoveAll(x => x == value);
                        break;

                    case "Insert":

                        value = int.Parse(inputLine[1]);
                        int index = int.Parse(inputLine[2]);

                        numbers.Insert(index, value);
                        break;
                }

                inputLine = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
