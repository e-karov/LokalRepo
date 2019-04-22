using System;

namespace _11.Rage_Expenses
{
    class Program
    {
        static void Main()
        {

            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double rageExpenses = 0;
            int counter = 0;

            for (int i = 1; i <= lostGames; i++)
            {

                if (i % 2 == 0)
                {
                    rageExpenses += headsetPrice;
                }

                if (i % 3 == 0)
                {
                    rageExpenses += mousePrice;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    rageExpenses += keyboardPrice;
                    counter++;
                    if (counter == 2)
                    {
                        rageExpenses += displayPrice;
                        counter = 0;
                    }
                }

                
            }

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
