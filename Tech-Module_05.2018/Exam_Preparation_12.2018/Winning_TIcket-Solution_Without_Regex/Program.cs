using System;

namespace Winning_TIcket_Solution_Without_Regex                 // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in tickets)
            {
                
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string leftHalf = ticket.Substring(0, 10);
                string rightHalf = ticket.Substring(10);

                int length = 0;
                char winningSymbol = ' ';

                for (int i = 6; i <= 10; i++)
                {

                    if (leftHalf.Contains(new string('@', i)) && rightHalf.Contains(new string('@', i)))
                    {
                        length = i;
                        winningSymbol = '@';
                    }

                    else if (leftHalf.Contains(new string('^', i)) && rightHalf.Contains(new string('^', i)))
                    {
                        length = i;
                        winningSymbol = '^';
                    }

                    else if (leftHalf.Contains(new string('#', i)) && rightHalf.Contains(new string('#', i)))
                    {
                        length = i;
                        winningSymbol = '#';
                    }

                    else if (leftHalf.Contains(new string('$', i)) && rightHalf.Contains(new string('$', i)))
                    {
                        length = i;
                        winningSymbol = '$';
                    }
                }

                if (length == 0)
                {
                    Console.WriteLine($"ticket \"{ ticket}\" - no match");
                }

                else if (length == 10)
                {
                    Console.WriteLine($"ticket \"{ ticket}\" - {length}{winningSymbol} Jackpot!");
                }

                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {length}{winningSymbol}");

                }
            }
           
        }

    }
}
