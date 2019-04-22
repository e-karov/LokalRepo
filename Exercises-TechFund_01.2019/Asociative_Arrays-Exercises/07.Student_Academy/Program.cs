using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Student_Academy               // 100/100
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (grades.ContainsKey(name) == false)
                {
                    grades.Add(name, new List<double>());
                }
                grades[name].Add(grade);
            }
            grades = grades.Where(g => g.Value.Average() >= 4.5).ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in grades.OrderByDescending(g => g.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
            }
        }
    }
}
