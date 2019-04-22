using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Bomb_Numbers          // 100/100
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] parameters = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bombNumber = parameters[0];
            int power = parameters[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int startIndex = i - power;
                    int leftDetonaton = power;
                    int rightDetonation = power;
                    
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                        leftDetonaton = i;
                    }
                    if (i + power > numbers.Count-1)
                    {
                        rightDetonation = numbers.Count - 1 -i;
                    }

                    numbers.RemoveRange(i, rightDetonation +1);
                    numbers.RemoveRange(startIndex, leftDetonaton);

                    i = 0;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
