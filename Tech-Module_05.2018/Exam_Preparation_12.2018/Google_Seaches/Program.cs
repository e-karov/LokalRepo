using System;

namespace Google_Seaches                    // 100 / 100
{
    class Program
    {
        static void Main()
        {
            long daysCount = long.Parse(Console.ReadLine());
            long usersCount = long.Parse(Console.ReadLine());
            decimal moneyPerSearch = decimal.Parse(Console.ReadLine());
            decimal income = 0;

            for (int i = 1; i <= usersCount; i++)
            {
                int wordsCount = int.Parse(Console.ReadLine());
                decimal searchIncome = moneyPerSearch;

                if (wordsCount > 5)
                {
                    continue;
                }

                if (i % 3 == 0)
                {
                    searchIncome *= 3;
                }

                if (wordsCount == 1)
                {   
                    searchIncome *= 2;
                }

               
                income += searchIncome; 
            }
            decimal totalIncome = income * daysCount;

            Console.WriteLine($"Total money earned for {daysCount} days: {totalIncome:F2}");
        }
    }
}
