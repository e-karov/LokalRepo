using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.List_Operations       // 100/100
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

            while (inputLine[0] != "End")
            {
                string command = inputLine[0].ToLower();
                switch (command)
                {
                    case "add":

                        int value = int.Parse(inputLine[1]);
                        numbers.Add(value);
                        break;

                    case "remove":

                        int index = int.Parse(inputLine[1]);
                        if (index < 0 || index > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(index);
                        }
                        break;

                    case "insert":

                        value = int.Parse(inputLine[1]);
                        index = int.Parse(inputLine[2]);
                        if (index < 0 || index > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(index, value);
                        }
                        break;

                    case "shift":

                        int count = int.Parse(inputLine[2]);
                        if (inputLine[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int temp = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(temp);
                            }
                        }
                        else if (inputLine[1] == "right")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int temp = numbers[numbers.Count-1];
                                numbers.RemoveAt(numbers.Count-1);
                                numbers.Insert(0, temp);
                            }
                        }
                        break;
                }
                inputLine = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
