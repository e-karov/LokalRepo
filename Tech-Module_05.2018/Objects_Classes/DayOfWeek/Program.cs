using System;
using System.Globalization;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.ToString("dddd"));
        }
    }
}
