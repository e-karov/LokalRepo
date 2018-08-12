using System;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main()
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float mPerSec = distance / ((hours * 60 + minutes) * 60 + seconds);
            float kmPerHour = (distance / 1000) / (hours + (minutes / 60)
                + (seconds / 3600));
            float milesPerHour = (distance / 1609) / (hours + (minutes / 60)
                + (seconds / 3600));

            Console.WriteLine(mPerSec);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
