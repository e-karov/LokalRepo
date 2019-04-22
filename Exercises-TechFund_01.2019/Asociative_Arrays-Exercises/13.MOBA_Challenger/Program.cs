using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.MOBA_Challenger                   // 100 / 100
{
    class Program
    {
        static void Main()
        {
            var playerSkills = new SortedDictionary<string, int>();
            var playersPositions = new Dictionary<string, SortedDictionary<string, int>>();

            string input = "";

            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] inputLine ;

                if (input.Contains("->"))
                {
                    inputLine = input.Split(" -> ").ToArray();
                    string player = inputLine[0];
                    string position = inputLine[1];
                    int skill = int.Parse(inputLine[2]);

                    if (playersPositions.ContainsKey(player) == false)
                    {
                        playersPositions.Add(player, new SortedDictionary<string, int>());
                        playerSkills.Add(player, 0);
                    }

                    playerSkills[player] += skill;

                    if (playersPositions[player].ContainsKey(position) == false)
                    {
                        playersPositions[player].Add(position, 0);
                    }

                    if (playersPositions[player][position] < skill)
                    {
                        playersPositions[player][position] = skill;
                    }


                }

                else if (input.Contains("vs"))
                {
                    inputLine = input.Split(" vs ").ToArray();
                    string player1 = inputLine[0];
                    string player2 = inputLine[1];

                    if (HaveCommonPosition(playersPositions, player1, player2))
                    {
                        if (playerSkills[player1] > playerSkills[player2])
                        {
                            playersPositions.Remove(player2);
                        }
                        else if (playerSkills[player1] < playerSkills[player2])
                        {
                            playersPositions.Remove(player1);
                        }
                    }
                   
                }
            }

            foreach (var kvp in playersPositions.OrderByDescending(p => p.Value.Values.Sum()))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Sum()} skill");

                foreach (var item in kvp.Value.OrderByDescending(i => i.Value))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }

        static bool HaveCommonPosition (Dictionary<string, SortedDictionary<string, int>> Positions, string player1, string player2)
        {
            
            if (Positions.ContainsKey(player1) && Positions.ContainsKey(player2))
            {
                foreach (var pos in Positions[player1])
                {
                    foreach (var pos2 in Positions[player2])
                    {
                        if (pos.Key == pos2.Key)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
