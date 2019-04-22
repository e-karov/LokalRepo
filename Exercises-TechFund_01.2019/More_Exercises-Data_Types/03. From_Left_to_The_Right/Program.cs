using System;


namespace _03._From_Left_to_The_Right
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string first = input.Substring(0, input.IndexOf(' '));
                string second = input.Substring(input.IndexOf(' ')+1);
                long num1 = long.Parse(first);
                long num2 = long.Parse(second);

                long sum = 0;

                if (num1 >= num2)
                {
                    while (Math.Abs(num1) > 0)
                    {
                        sum += Math.Abs(num1) % 10;
                        num1 /= 10;
                    }

                }
                else
                {
                    while (Math.Abs(num2) > 0)
                    {
                        sum += Math.Abs (num2) % 10;
                        num2 /= 10;
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}
