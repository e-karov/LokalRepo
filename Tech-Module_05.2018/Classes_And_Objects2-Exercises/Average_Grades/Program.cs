using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split();
            string name = input[0];
            double[] grades = new double[input.Length - 1];

            for (int i = 1; i < input.Length; i++)
            {
                grades[i] = int.Parse(input[i]);
            }

            List<Student> students = new List<Student>() { name, grades }
        }

        class Student
        {
            public string Name { get; set; }
            public double[] Grades { get; set; }
            
             double Average
            {
                
                    return Grades.Average();
               
            }

            public string
        }
    }
}
