using System;
using System.Linq;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool foundSum = TripleSum(numbers);
            if (!foundSum)
            {
                Console.WriteLine("No");
            }
        }

        private static bool TripleSum(int[] numbers)
        {
            bool found = false;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];

                    if (numbers.Contains(sum))
                    {
                        found = true;
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                    }
                }
            }
            return found;
        }
    }
}
