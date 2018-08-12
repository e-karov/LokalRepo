using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int emplId = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine($"Employee ID: {emplId:D8}");
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}
