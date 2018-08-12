using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student() { Name = "Pesho", Age = 19 };
            student1.Age++;

            Console.WriteLine(student1.Name, student1.Age);

            student1.SayHello();

            Student[] students = new Student[2]
            {
                new Student ("Pesho", 19),
                new Student ("Gosho", 23)
            };

            foreach (Student student in students)
            {
                Console.WriteLine();
            }
        }
    }

    class Student
    {
        public string Name { get; set; } = "";
        public int Age { get; set; } = 20;

        public Student()
        {

        }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine("Hi! I am " + this.Name);
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}

