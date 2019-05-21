using System;
using System.Collections.Generic;
using System.Linq;


namespace Snowman
{
    class Program
    {
        static void Main()
        {
            List<int> snowmanInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            while (snowmanInput.Count > 1)
            {
                List<int> indexToRemove = new List<int>();

                int attackerIndex = 0;
                int targetIndex = 0;
                for (attackerIndex = 0; attackerIndex < snowmanInput.Count; attackerIndex++)
                {
                    if (indexToRemove.Contains(attackerIndex))
                    {
                        continue;
                    }
                    targetIndex = snowmanInput[attackerIndex] % snowmanInput.Count;

                    int difference = Math.Abs(attackerIndex - targetIndex);
                    int winnerIndex = -1;
                    int looserIndex = -1;

                    if (difference == 0)
                    {
                        Console.WriteLine($"{attackerIndex} performed harakiri");
                        looserIndex = attackerIndex;
                        looserIndex = targetIndex;
                    }

                    else if (difference % 2 == 0)
                    {
                        winnerIndex = attackerIndex;
                        looserIndex = targetIndex;
                        Console.WriteLine($"{attackerIndex } x {targetIndex } -> { winnerIndex} wins");
                    }

                    else if(difference % 2 > 0)
                    {
                        winnerIndex = targetIndex;
                        looserIndex = attackerIndex;
                        Console.WriteLine($"{attackerIndex } x {targetIndex } -> { winnerIndex} wins");
                    }

                    

                    if (indexToRemove.Contains(looserIndex) == false)
                    {
                        indexToRemove.Add(looserIndex);
                    }
                    if (snowmanInput.Count == indexToRemove.Count+1)
                    {
                        break;
                    }

                }

                SnowManClearing(snowmanInput, indexToRemove);
            }
        }

        static List<int> SnowManClearing(List<int> input, List<int> toRem)
        {
            toRem = toRem.OrderBy(x => x).ToList();

            for (int i = toRem.Count - 1; i >= 0; i--)
            {
                input.RemoveAt(toRem[i]);
            }
            return input;
        }
    }
}
