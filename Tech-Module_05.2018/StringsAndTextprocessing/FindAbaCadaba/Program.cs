using System;

namespace FindAbaCadaba
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            string replaced = input.Replace("a", "*");

            //string[] splittedInput = input.Split("123sjg><|'".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            //string pattern = Console.ReadLine().ToLower();
            //int index = input.IndexOf(pattern);
            //int count = 0;

            //while (index != -1)
            //{
            //    count++;
            //    index = input.IndexOf(pattern, index);
            //}
            //Console.WriteLine(count);

            //string subStr = input.Substring(1, 2);
            //Console.WriteLine(subStr);
            //var result = String.Compare(subStr, pattern); // resultat: -1, 0, ili 1.
            //bool result2 = String.Equals(subStr, pattern); // izpolzva kompparator za stringove i vru6ta true/false.
            Console.WriteLine(  replaced);



        }
    }
}
