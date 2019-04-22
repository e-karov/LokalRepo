using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Sort_Numbers
{
    class Program
    {
        static void Main()
        {
           
            List<double> numbers = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                numbers.Add(double.Parse(Console.ReadLine()));
            }

            foreach (var num in numbers.OrderByDescending(x =>x))
            {
                Console.WriteLine(num);
            }
        }
    }
}
