using System;

namespace _07.Water_Overflow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int tankCapacity = 255;
            int totalWaterContent = 0;

            for (int i = 0; i < n; i++)
            {
                int freeCapacity = tankCapacity - totalWaterContent;

                int addedWater = int.Parse(Console.ReadLine());

                if (freeCapacity >= addedWater)
                {
                    totalWaterContent += addedWater;
                }

                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }

            Console.WriteLine(totalWaterContent);
        }
    }
}
