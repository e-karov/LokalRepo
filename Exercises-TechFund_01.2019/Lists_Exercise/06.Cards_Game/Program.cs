using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Cards_Game        // 100/100
{
    class Program
    {
        static void Main()
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();
           
            for (int i = 0; i < Math.Min(player1.Count, player2.Count); i++)
            {
                if (player1[i] > player2[i])
                {
                    player1.Add(player1[i]);
                    player1.Add(player2[i]);
                    player1.RemoveAt(i);
                    player2.RemoveAt(i);

                    i--;
                }

                else if (player1[i] == player2[i])
                {
                    player1.Remove(player1[i]);
                    player2.Remove(player2[i]);

                    i--;
                }

                else if (player1[i] < player2[i])
                {
                    player2.Add(player2[i]);
                    player2.Add(player1[i]);
                    player1.RemoveAt(i);
                    player2.RemoveAt(i);

                    i--;
                }
            }

            int sum1 = player1.Sum();
            int sum2 = player2.Sum();

            if (sum1 > sum2)
            {
                Console.WriteLine($"First player wins! Sum: {sum1}");
            }
            else if (sum1 < sum2)
            {
                Console.WriteLine($"Second player wins! Sum: {sum2}");
            }
        }
    }
}
