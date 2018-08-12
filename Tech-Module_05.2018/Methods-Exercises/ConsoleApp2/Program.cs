using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStudent("Kiro", 25, 5.49);
        }

        static void PrintStudent(string name, int age, double grade)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
