using System;

namespace Month_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;

                case "Spain":
                case "Mexiko":
                    Console.WriteLine("Spanish");
                    break;

                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }
    }
}
