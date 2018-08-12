using System;

namespace HomeWorks1
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Health: |" + new string('|', currentHealth) +
            //    new string('.', (maxHealth - currentHealth)) + "|");
            //Console.WriteLine($"Energy: |{new string('|', currentEnergy)}" +
            //    $"{new string('.', (maxEnergy - currentEnergy))}|");
            Console.WriteLine("Name: " + name);
            Console.Write("Health: " + "|");
            for (int i = 0; i < maxHealth; i++)
            {
                if ((currentHealth - i) > 0)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(".");

                }
            }
            Console.WriteLine("|");
            Console.Write("Energy: |");
            for (int i = 0; i < maxEnergy; i++)
            {
                if ((currentEnergy - i) > 0)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(".");

                }
            }
            Console.WriteLine("|");

        }
    }
}
