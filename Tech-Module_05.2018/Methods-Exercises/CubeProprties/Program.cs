using System;

namespace CubeProprties
{
    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();

            Console.WriteLine($"{CubeProperty(side, property):f2}");
           
        }

       

        static double CubeProperty(double sideLength, string property)
        {
            double diagonal = 0;
            double result = 0;
            if (property == "area")
            {
                result = sideLength * sideLength * 6;
            }
            else if (property == "face")
            {
                diagonal = Math.Sqrt(sideLength * sideLength + sideLength * sideLength);
                result = diagonal;
            }

            else if (property == "volume")
            {
                result = sideLength * sideLength * sideLength;
            }

            else if (property == "space")
            {
                result = Math.Sqrt(sideLength * sideLength + diagonal * diagonal);
            }
            return result;
        }
    }
}
