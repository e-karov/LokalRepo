using System;
using System.Linq;

namespace MaxSequenceEqualElements
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxStart = 0;
            int maxCount = 1;
            int currentCount = 1;
            int currentStart = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i-1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxStart = i;
                    }
                }
                
            }

            for (int i = maxStart; i < (maxStart + maxCount); i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
