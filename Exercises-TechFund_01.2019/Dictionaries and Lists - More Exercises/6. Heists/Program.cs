using System;

namespace _6._Heists
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int jewelPrice = int.Parse(input[0]);
            int goldPrice = int.Parse(input[1]);

            int goldEarnings = 0;
            int jewelEarnings = 0;
            int totalEarnings = 0;
            int totalExpences = 0;
            string[] command = Console.ReadLine().Split();

            while (true)
            {
                if (command[0] == "Jail")
                {
                    break;
                }

                string loot = command[0];
                int expences = int.Parse(command[1]);
                
                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '$')
                    {
                        goldEarnings += goldPrice;
                    }
                   
                    if (loot[i] == '%')
                    {
                        
                        jewelEarnings += jewelPrice;
                    }

                   }
               
                command = Console.ReadLine().Split();
            }
            totalExpences += expences;
            totalEarnings += (jewelEarnings + goldEarnings) - expences;
            if (totalExpences < totalEarnings)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - totalExpences}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpences - totalEarnings}.");
            }
        }
    }
}
