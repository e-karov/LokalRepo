using System;
using System.Linq;

namespace _09.Kamino.Factory        // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int bestIndex = 0;
            int bestLen = 1;
            int bestSum = 0;
            int[] bestSequence = new int[n];
            int bestSample = 1;
            int currentSample = 0;

            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                int[] array = input
                    .Split(new[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int counter = 0;
                
                currentSample++;
              
                for (int i = 0; i < n; i++)
                {
                    if (array[i] == 1)
                    {
                        counter++;
                      
                        if (counter > bestLen)
                        {
                            bestLen = counter;
                            bestIndex = i;
                            bestSample = currentSample;
                            bestSum = array.Sum();
                            bestSequence = array;
                        }
                        else if (counter == bestLen)
                        {
                            if (bestIndex > i)
                            {
                                bestIndex = i;
                                bestSample = currentSample;
                                bestSum = array.Sum();
                                bestSequence = array;
                            }
                            else if (bestIndex == i)
                            {
                                if (bestSum < array.Sum())
                                {
                                    bestSample = currentSample;
                                    bestSum = array.Sum();
                                    bestSequence = array;
                                }
                            }

                        }
                    }
                    else
                    {
                        counter = 0;
                    }

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequence.Sum()}.");

            Console.WriteLine(String.Join(' ', bestSequence));

        }
    }
}
