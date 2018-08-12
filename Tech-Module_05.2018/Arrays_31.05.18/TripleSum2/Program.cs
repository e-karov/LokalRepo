using System;
using System.Linq;

namespace TripleSum2
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool sumFound = TripleSum(numbers);

            if (!sumFound)
            {
                Console.WriteLine("No");
            }

        }
        static bool TripleSum(int[] nums)
        {
            bool found = false;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];

                    if (nums.Contains(sum))
                    {
                        found = true;
                        Console.WriteLine($"{nums[i]} + {nums[j]} == {sum}");
                    }
                }
            }
            return found;
        }


    }
}
