using System;

namespace _10._Spice_Must_Flow
{
    class Program
    {
        static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());

            int totalSpice = 0;
            int expectedYield = startingYield;
            int counter = 0;

            while (expectedYield >= 100)
            {
                totalSpice += expectedYield;
                expectedYield -= 10;
                totalSpice -= 26;
                counter++;
            }

            if (totalSpice > 26)
            {
                totalSpice -= 26;
            }

            Console.WriteLine(counter);
            Console.WriteLine(totalSpice);


        }
    }
}
