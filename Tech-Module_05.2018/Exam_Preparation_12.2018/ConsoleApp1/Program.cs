using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string commandLine = "";

            while ((commandLine = Console.ReadLine()) != "3:1")
            {
                string[] commands = commandLine.Split();
                string command = commands[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    input = MergeList(input, startIndex, endIndex);

                }

                if (command == "divide" )
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);

                    input = DivideElements(input, index, partitions);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }

        static int CorrectIndex (int index, int maxIndex)
        {
            if (index < 0 )
            {
                index = 0;
            }

            if (index >= maxIndex )
            {
                index = maxIndex - 1;
            }

            return index;
        }

        static List<string> MergeList (List<string> input, int startIndex, int endIndex)
        {
            startIndex = CorrectIndex(startIndex, input.Count);
            endIndex = CorrectIndex(endIndex, input.Count);
           

            List<string> merged = new List<string>();

            for (int i = 0; i < startIndex; i++)
            {
                merged.Add(input[i]);
            }

            StringBuilder sb = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                sb.Append(input[i]);

            }

            merged.Add(sb.ToString());

            for (int i = endIndex + 1; i < input.Count; i++)
            {
                merged.Add(input[i]);
            }

            return merged;
        }   

        static List <string> DivideElements(List<string> input, int index, int partitions )
        {

            List<string> newList = new List<string>();
            string strToDivide = input[index];
            int partitionLength = strToDivide.Length / partitions;
           
            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    newList.Add(strToDivide.Substring(i * partitionLength));
                }
                else
                {

                    newList.Add(strToDivide.Substring((i * partitionLength), partitionLength));
                }                 
            }
            input.RemoveAt(index);
            input.InsertRange(index, newList);

            return input;
        }
    }
}

