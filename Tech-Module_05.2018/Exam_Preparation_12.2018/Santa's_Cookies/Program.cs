namespace Santa_s_Cookies               // 100 / 100
{
    using System;
    
    public  class Program
    {
        public static void Main()
        {
            int batchCount = int.Parse(Console.ReadLine());

            int totalBoxes = 0;

            for (int i = 0; i < batchCount; i++)
            {
                int flour = int.Parse(Console.ReadLine());
                int sugar = int.Parse(Console.ReadLine());
                int cocoa = int.Parse(Console.ReadLine());

                int flourCups = flour / 140;
                int cocoaSpoons = cocoa / 10;
                int sugarSpoons = sugar / 20;

                if (flourCups <= 0 || cocoaSpoons <= 0 || sugarSpoons <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                    continue;
                }

                else
                {
                    int totalCookiesPerBake = (140 + 10 + 20) * Math.Min(flourCups, Math.Min(sugarSpoons, cocoaSpoons)) / 25;

                    int boxesCount = totalCookiesPerBake / 5;
                    totalBoxes += boxesCount;

                    Console.WriteLine($"Boxes of cookies: {boxesCount}");
                }
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
