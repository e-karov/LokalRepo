using System;

namespace DaysNames
{
    class Program
    {
        static void Main()
        {
            string[] daysNames = //new string [7]
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };
            //var daysName = new string [7]
            //{
            //    "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            //};
            int day = int.Parse(Console.ReadLine());

            if (day > 7 || day < 1)
                Console.WriteLine("Invalid day");
            else
            {
                Console.WriteLine(daysNames[day - 1]);
            }
        }
    }
}
