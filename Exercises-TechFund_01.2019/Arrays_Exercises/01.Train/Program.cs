using System;


namespace _01.Train
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }

            foreach (var ind in arr)
            {
                Console.Write($"{ind} ");
            }

            Console.WriteLine();
            Console.WriteLine(sum); 
        }
    }
}
