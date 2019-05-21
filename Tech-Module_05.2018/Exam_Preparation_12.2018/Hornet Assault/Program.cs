using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Hornet_Assault
{
    class Program
    {
        static void Main()
        {
            List<long> bees = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            long hornetPower = hornets.Sum() ;
            
            for (int i = 0; i < bees.Count; i++)
            {
                if (hornetPower > bees[i])
                {
                    bees.RemoveAt(i);
                    i--;
                }
                else if (hornetPower <= bees[i])
                {
                    bees[i] -= hornetPower;
                    if (bees[i] <= 0)
                    {
                        bees.RemoveAt(i);
                        i--;
                    }
                    hornets.RemoveAt(0);
                    if (hornets.Count == 0)
                    {
                        break;
                    }
                    hornetPower = hornets.Sum();
                }
            }

            if (bees.Count > 0)
            {
                Console.WriteLine(string.Join(" ", bees));
            }

            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }


        }

    }
}
