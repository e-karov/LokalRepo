using System;
using System.Text.RegularExpressions;

namespace Winning_Ticket                            // 100 / 100
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string str in input)
            {
                if (str.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                Match jackpotMatch = Regex.Match(str, @"([@\$#\^]{10})(\1)");

                if (jackpotMatch.Success)
                {
                    Console.WriteLine($"ticket \"{str}\" - {jackpotMatch.Groups[1].Length}{jackpotMatch.Groups[1].Value[0]} Jackpot!");
                    continue;
                }


                string left = str.Substring(0, 10);
                string right  = str.Substring(10);
                Match leftMatch = Regex.Match(left, @"@{6,}|\^{6,}|\${6,}|#{6,}");
                Match rightMatch = Regex.Match(right, @"@{6,}|\^{6,}|\${6,}|#{6,}");

                 if (leftMatch.Success && rightMatch.Success 
                    && leftMatch.Value[0].Equals(rightMatch.Value[0]))
                {
                    int length1 = leftMatch.Value.Length;
                    int length2 = rightMatch.Value.Length;
                    int shorterLength = Math.Min(length1, length2);

                    char symbol = leftMatch.Value[0];

                    Console.WriteLine($"ticket \"{str}\" - {shorterLength}{symbol}");
                }

                else
                {
                    Console.WriteLine($"ticket \"{str}\" - no match");
                }
            }
        }
    }
}
