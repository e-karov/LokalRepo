using System;

namespace _11.Poke_Mon
{
    class Program
    {
        static void Main()
        {
            int initialPower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int targetCounter = 0;
            int power = initialPower;

            while (power >= distance)
            {
                power -= distance;
                targetCounter++;

                if (power == initialPower * 0.5 )
                {
                    try
                    {
                        power /= exhaustionFactor;
                    }
                    catch (Exception)
                    {

                       continue;
                    }
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(targetCounter);
        }
    }
}
