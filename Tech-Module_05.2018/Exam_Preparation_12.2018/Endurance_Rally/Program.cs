using System;
using System.Collections.Generic;
using System.Linq;

namespace Endurance_Rally
{
    class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split();
            double[] zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            long[] checkpopintIndexes = Console.ReadLine().Split().Select(long.Parse).ToArray();


            for (int i = 0; i < names.Length; i++)
            {
                string driversName = names[i];

                double startingFuel = (int)driversName[0];

                for (int k = 0; k < zones.Length; k++)
                {

                    if (checkpopintIndexes.Contains(k))
                    {
                        startingFuel += zones[k];
                    }

                    else
                    {
                        startingFuel -= zones[k];
                    }

                    if (startingFuel <= 0)
                    {
                        Console.WriteLine($"{driversName} - reached {k}");
                        break;
                    }

                }

                if (startingFuel >0)
                {
                    Console.WriteLine($"{driversName} - fuel left {startingFuel:F2}");
                }
                
            }

               
            

    }
}
}
