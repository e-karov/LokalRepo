using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Anonym          
{
    class Program        // 100/100 
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string[] commandLine = Console.ReadLine().Split();

            while (commandLine[0] != "3:1")
            {
                string command = commandLine[0];

                if (command == "merge")
                {
                    MergeArraysElements(input, commandLine); 
                }

                else if (command == "divide")
                {
                    DivideArraysElements(input, commandLine);
                }

                commandLine = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(' ', input));
        }

        private static List<string> DivideArraysElements(List<string> input, string[] commandLine)
        {
            int index = int.Parse(commandLine[1]);
            int partitions = int.Parse(commandLine[2]);
            string element = input[index];
            if (partitions == 0)
            {
                input.Remove(element);
                return input;
            }
            else if (partitions > element.Length)
            {
                partitions = element.Length;
            }
            int partinionsLength = element.Length / partitions;

            for (int i = 1; i <= partitions; i++)
            {
                string partStr = "";

                if (i == partitions)
                {
                    partStr = element;
                }
                else
                {
                    partStr = element.Substring(0, partinionsLength);
                    element = element.Substring(partinionsLength);
                }
                input.Insert (index+i, partStr);
            }
            input.RemoveAt(index);
            return input;
        }

        private static List<string> MergeArraysElements(List<string> input, string[] commandLine)
        {
            int startIndex = int.Parse(commandLine[1]);
            int endIndex = int.Parse(commandLine[2]);
            if (startIndex > endIndex || startIndex > input.Count - 1)
            {
                startIndex = Math.Abs(endIndex - startIndex);
            }
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex > input.Count - 1)
            {
                endIndex = input.Count - 1;
            }

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                input[startIndex] += input[i];

            }
            input.RemoveRange(startIndex + 1, (endIndex - startIndex));

            return input;
        }
    }
}
