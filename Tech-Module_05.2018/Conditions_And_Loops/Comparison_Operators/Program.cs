using System;

namespace Comparison_Operators
{
    class Program
    {
        static void Main()
        {
            //int a = 5;
            //int b = 10;

            //Console.WriteLine(a < b);
            //Console.WriteLine(a > b);
            //Console.WriteLine(a == b);
            //Console.WriteLine(a <= b);
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;

           // minutes += 30;
            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours == 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");

        }
    }
}
