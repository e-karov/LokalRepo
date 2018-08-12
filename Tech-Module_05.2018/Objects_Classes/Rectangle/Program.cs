using System;

namespace Rectangle
{
    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(10);
            Rectangle rectangle2 = new Rectangle(10, 5);
            Console.WriteLine(rectangle.IsSquare);
            Console.WriteLine(rectangle2.Perimeter);
        }
    }

    class Rectangle
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public bool IsSquare { get; set; }

        public double Perimeter
        {
            get
            {
                return SideA * 2 + SideB * 2;
            }
        }

        public double Area
        {
            get
            {
                return SideA * SideB;
            }
        }

        public Rectangle (int side)
        {
            this.SideA = side;
            this.SideB = side;
            this.IsSquare = true;

        }

        public Rectangle (int sideA, int sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }
    }
}
