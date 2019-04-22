using System;
using System.Numerics;

namespace _12.Snowballs
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            BigInteger maxValue = 0;

            int bestQuality = 0;
            int bestSnow = 0;
            int bestTime = 0;

            for (int i = 0; i < count; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (maxValue < snowballValue)
                {
                    maxValue = snowballValue;
                    bestQuality = snowballQuality;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                }

            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {maxValue} ({bestQuality})");
        }
    }
}
