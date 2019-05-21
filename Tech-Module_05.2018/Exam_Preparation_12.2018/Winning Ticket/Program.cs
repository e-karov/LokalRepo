using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Winning_Ticket                // 70 / 100
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
                }

                else if(str.Length == 20)
                {
                    Match jackpotMatch = Regex.Match(str, @"([@\$#\^]{10})(\1)");
                    Regex regex = new Regex(@"(\${6,}|@{6,}|\^{6,}|#{6,})(.*?)(\1)");

                    if (jackpotMatch.Success)
                    {
                        Console.WriteLine($"ticket \"{str}\" - {jackpotMatch.Groups[1].Length}{jackpotMatch.Value[0]} Jackpot!");
                    }

                    else if (regex.Match(str).Success)
                    {
                        int length = regex.Match(str).Groups[1].Length;
                        char symbol = regex.Match(str).Groups[1].Value[0];

                       Console.WriteLine($"ticket \"{str}\" - {regex.Match(str).Groups[1].Length}{symbol}");
                     
                    }

                    else
                    {
                        Console.WriteLine($"ticket \"{str}\" - no match");
                    }
                }

                
            }
        }
    }
}
