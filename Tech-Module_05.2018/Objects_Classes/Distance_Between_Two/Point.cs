using System;
using System.Collections.Generic;
using System.Text;

namespace Distance_Between_Two
{
    static void Main()
    {
        Student student = new Student("Pesho", 19);
        Student student2 = new Student();

        Console.WriteLine(student2.Age);
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; } = 20;

        public Student()
        {

        }
        public Student (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
   
    
}
