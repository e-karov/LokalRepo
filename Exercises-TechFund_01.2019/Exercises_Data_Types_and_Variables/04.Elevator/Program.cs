using System;

namespace _04.Elevator
{
    class Program
    {
        static void Main()
        {
            int personsCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = personsCount / capacity;
            if (personsCount % capacity > 0)
            {
                courses += 1;
            }

            // or int courses = (int)Math.Ceiling((double) personsCount / capacity)

            Console.WriteLine(courses);
        }
    }
}
