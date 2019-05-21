using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int maxSnoballSnow = 0;
            int maxSnowballTime = 0;
            int maxSnowballQuality = 0;
            BigInteger maxSnowballValue = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime  = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > maxSnowballValue)
                {
                    maxSnowballValue = snowballValue;
                    maxSnoballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{maxSnoballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");
        }
    }
}
