using System;

namespace Hornet_WIngs
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingsFlaps = int.Parse(Console.ReadLine());
            double mettersPer1000Fl = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            double flapsPerSec = 100;

            double totalDistance = (wingsFlaps / 1000) * mettersPer1000Fl;
            int time = (wingsFlaps / 100) + (wingsFlaps / endurance * 5);

            Console.WriteLine("{0:f2} m." , totalDistance);
            Console.WriteLine("{0} s." , time);
        }
    }
}
