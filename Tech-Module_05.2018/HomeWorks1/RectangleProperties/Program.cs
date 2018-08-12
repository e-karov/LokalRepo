using System;

namespace RectangleProperties
{
    class Program
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = (length + height) * 2;
            double area = length * height;
            double diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(height, 2));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);


        }
    }
}
