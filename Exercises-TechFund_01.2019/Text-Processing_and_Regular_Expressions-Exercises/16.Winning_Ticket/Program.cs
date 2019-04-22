using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _16.Winning_Ticket                // 70 / 100
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string winPattern = @"(\@{6,}|\${6,}|\^{6,}|#{6,})(.*?)(\1)";
            string jackpotPattern = @"(@{10}|\${10}|\#{10}|\^{10})(\1)";

            foreach (var ticket in input)
            {
                Match match = Regex.Match(ticket, winPattern);
                Match jackPotMatch = Regex.Match(ticket, jackpotPattern);

                if (ticket.Length < 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                if (match.Success)
                {
                    int length = match.Groups[1].Value.Length;
                    char symbol = match.Groups[1].Value.First();

                    if (length == 10)
                    {
                      
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol} Jackpot!");
                    }

                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol}");
                    }

               
                }

                

                if ( !match.Success && ! jackPotMatch.Success)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }

            }
        }
    }
}
//namespace Winning_Ticket                // 80 / 100
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            string[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

//            foreach (string str in input)
//            {
//                if (str.Length != 20)
//                {
//                    Console.WriteLine("invalid ticket");
//                }

//                else if (str.Length == 20)
//                {
//                    Match jackpotMatch = Regex.Match(str, @"(@{10}|\${10}|\#{10}|\^{10})(\1)");
//                    Regex regex = new Regex(@"(\${6,}|@{6,}|\^{6,}|#{6,})(.*?)(\1)");

//                    if (jackpotMatch.Success)
//                    {
//                        Console.WriteLine($"ticket \"{str}\" - {jackpotMatch.Groups[1].Length}{jackpotMatch.Value[0]} Jackpot!");
//                    }

//                    else if (regex.Match(str).Success)
//                    {
//                        int length = regex.Match(str).Groups[1].Length;
//                        char symbol = regex.Match(str).Groups[1].Value[0];

//                        Console.WriteLine($"ticket \"{str}\" - {regex.Match(str).Groups[1].Length}{symbol}");

//                    }

//                    else
//                    {
//                        Console.WriteLine($"ticket \"{str}\" - no match");
//                    }
//                }


//            }
//        }
//    }
//}
