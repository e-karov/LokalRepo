using System;

namespace _10.Padawan_Equipment
{
    class Program
    {
        static void Main()
        {
            double startMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabresPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalSabresPrice = sabresPrice * Math.Ceiling(students * 1.1);
            double totalrobesPrice = robesPrice * students;
            double totalbeltsPrice = beltsPrice * (students - (students / 6));

            double totalCosts = totalbeltsPrice + totalrobesPrice + totalSabresPrice;

            if (startMoney >= totalCosts)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCosts:F2}lv.");
            }

            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalCosts - startMoney):F2}lv more.");
            }
        }
    }
}
