using System;

namespace _08.Beer_Kegs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double maxVolúme = 0;
            string biggestKeg = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > maxVolúme)
                {
                    maxVolúme = volume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
