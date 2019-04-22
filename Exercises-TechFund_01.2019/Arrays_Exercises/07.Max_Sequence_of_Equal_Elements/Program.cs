using System;
using System.Linq;

namespace _07.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxNumber = array[0];
            int maxCount = 1;
            int counter = 1;

            for (int i = 0; i < array.Length-1; i++)
            {
                int nextIndex = i + 1;
               
                if (array[i] == array[nextIndex])
                {
                    counter++;

                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        maxNumber = array[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{maxNumber} ");
            }
            Console.WriteLine();
        }
    }
}
