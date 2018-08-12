using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGames
{

    class Program
    {
        static void Main(string[] args)
        {
            var playersAndCards = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "JOKER")
                {
                    break;
                }

                string[] tokens = line.Split(": ");
                string player = tokens[0];
                List<string> cards = tokens[1].Split(", ").ToList();

                if (!playersAndCards.ContainsKey(player))
                {
                    playersAndCards.Add(player, new List<string>());
                    playersAndCards[player] = cards;
                }
                else
                {
                    playersAndCards[player].AddRange(cards);
                }
                playersAndCards[player] = playersAndCards[player].Distinct().ToList();
            }
        }

        static int Power(Dictionary<string, List<string>> dict, string player)
        {
            
        }
    }
}
