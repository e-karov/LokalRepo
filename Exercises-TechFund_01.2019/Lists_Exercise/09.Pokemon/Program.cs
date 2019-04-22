using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Pokemon                   // 100 / 100
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            long sum = 0;
            int index = 0;
            
            while (input.Count != 0)
            {
                index = int.Parse(Console.ReadLine());
                int currentValue =0;
               
                if (index < 0)
                {
                    currentValue = input[0];
                    ChangElementsValue(input, currentValue);
                    input[0] = input[input.Count - 1];
                }

                else if (index > input.Count - 1)
                {
                    currentValue = input[input.Count - 1];
                    ChangElementsValue(input, currentValue);
                    input[input.Count-1] = input[0];
                }

                else
                {
                    currentValue = input[index];
                    input.RemoveAt(index);
                    ChangElementsValue(input, currentValue);
                }
                sum += currentValue;
            }

            Console.WriteLine(sum);
        }

        static List<int> ChangElementsValue(List<int> input, int currentValue)
        {
            for (int j = 0; j < input.Count; j++)
            {
               
                    if (input[j] <= currentValue)
                    {
                        input[j] += currentValue;
                    }
                    else if (input[j] > currentValue)
                    {
                        input[j] -= currentValue;
                    }
               
            }

            return input;
        }
    }
}
