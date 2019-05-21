using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main()
        {
            int homesToVisit = int.Parse(Console.ReadLine());
            int initialPresents = int.Parse(Console.ReadLine());

            int presentsLeft = initialPresents;
            int TotalAdditionalPresents = 0;
            int counter = 0;

            for (int i = 1; i <= homesToVisit; i++)
            {
                int currentsGifts = int.Parse(Console.ReadLine());
                
                if (presentsLeft < currentsGifts)
                {
                    counter++;
                    int difference = currentsGifts - presentsLeft;
                    int additionalPresents = (initialPresents / i) *
                        (homesToVisit - i) + difference;

                    presentsLeft = (initialPresents / i) *
                        (homesToVisit - i);

                    TotalAdditionalPresents += additionalPresents;
                }

                else
                {
                    presentsLeft -= currentsGifts;
                }

            }

            if (counter == 0)
            {
                Console.WriteLine(presentsLeft);
            }
            else
            {
                Console.WriteLine(string.Join("\n", counter, TotalAdditionalPresents));
            }
        }
    }
}
