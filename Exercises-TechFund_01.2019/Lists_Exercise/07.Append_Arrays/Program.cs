using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Append_Arrays     // 100/100
{
    class Program
    {
        static void Main()
        {
            string[] inputLine = Console.ReadLine().Split('|');
            List<int> resultList = new List<int>();

            for (int i = inputLine.Length-1; i >= 0 ; i--)
            {
                int[] currentArray = inputLine[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                resultList.AddRange(currentArray);
            }

            Console.WriteLine(string.Join(' ', resultList));
        }
    }
}
