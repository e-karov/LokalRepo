using System;

namespace Melrah__Shake
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string key = Console.ReadLine();

            while (true)
            {
                int firstIndex = text.IndexOf(key);
                int lastIndex = text.LastIndexOf(key);

                if (key == "" || firstIndex == -1 || firstIndex == lastIndex)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                    Environment.Exit(0);
                }

                text = text.Remove(lastIndex, key.Length);
                text = text.Remove(firstIndex, key.Length);
                key = key.Remove(key.Length / 2, 1);

                Console.WriteLine("Shaked it.");
            }
        }
    }
}
