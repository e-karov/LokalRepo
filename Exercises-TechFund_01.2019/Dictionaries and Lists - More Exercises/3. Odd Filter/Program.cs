using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Odd_Filter
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            List<int> nums = new List<int>();

            foreach (var item in input)
            {
                int currentNum = int.Parse(item);

                if (currentNum % 2 != 0)
                {
                    continue;
                }

                else
                {
                    nums.Add(currentNum);
                }
            }

            double av = nums.Average();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > av)
                {
                    nums[i] += 1;
                }
                else
                {
                    if (nums[i] <= av)
                    {
                        nums[i] -= 1;
                    }
                }
            }

            Console.Write(string.Join(" ", nums));
        }
    }
}
