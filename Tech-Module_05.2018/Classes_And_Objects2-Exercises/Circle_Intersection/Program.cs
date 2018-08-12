using System;

namespace Circle_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] circle1 = Console.ReadLine().Split();
            string[] circle2 = Console.ReadLine().Split();

            Point p1 = new Point { X = int.Parse(circle1[0]), Y = int.Parse(circle1[1]) };
            Point p2 = new Point { X =int.Parse(circle2[0]), Y = int.Parse(circle2[1]) };
           
            Circle c1 = new Circle {p = p1, radius = int.Parse(circle1[2]) };
            Circle c2 = new Circle {p = p2, radius = int.Parse(circle2[2]) };

            bool areIntersecting = Intersect(c1, c2);

            if (areIntersecting)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point()
            {

            }

            public  Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        static double CalcDistance(Point p1, Point p2)
        {
            double disance = Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));

            return disance;
        }

        class Circle
        {
            public Point p { get; set; }
            public double radius { get; set; }
        }

        static bool Intersect (Circle c1, Circle c2)
        {
            double distance = CalcDistance(c1.p, c2.p);
            bool areIntersecting = false;

            if (distance <= c1.radius + c2.radius)
            {
                areIntersecting = true;
            }

            return areIntersecting;
        }
         
    }
}
