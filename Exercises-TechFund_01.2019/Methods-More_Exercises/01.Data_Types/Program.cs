using System;

namespace _01.Data_Types
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = "";

            if (input == "int")
            {
                int number = int.Parse(Console.ReadLine());
                output = MultiplyIntegerBy2(number).ToString();
            }

            else if (input == "real")
            {
                double number = double.Parse(Console.ReadLine());
                output = MultiplyDouble(number);
            }
            else if (input == "string")
            {
                string str = Console.ReadLine();
                output = $"${str}$";
            }
            Console.WriteLine(output);
        }


        private static string MultiplyDouble(double number)
        {
            string result = $"{(number * 1.5):F2}";
            return result;
        }

        private static int MultiplyIntegerBy2(int number)
        {
            int result = number * 2;

            return result;
        }
    }
}
