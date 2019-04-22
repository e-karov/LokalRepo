using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Chars_in_String
{
    class Program
    {
        static void Main()
        {
            string[] characters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var word    in characters)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (counts.ContainsKey(word[i]) == false)
                    {
                        counts.Add(word[i], 0);
                    }

                    counts[word[i]]++;
                }
            }

            foreach (var ch in counts)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }

        }
    }
}
