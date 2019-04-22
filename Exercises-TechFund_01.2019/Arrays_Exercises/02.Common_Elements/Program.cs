using System;

namespace _02.Common_Elements
{
    class Program
    {
        static void Main()
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();

            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (firstArr[j].Equals(secondArr[i]))
                    {
                        Console.Write($"{firstArr[j]} ");
                    }
                    
                }
            }
            Console.WriteLine();
        }
    }
}
