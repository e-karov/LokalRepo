using System;

namespace _14.HTML                      // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string comment = Console.ReadLine();

            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");

            while (comment != "end of comments")
            {
                if (comment == "end of comments")
                {
                    return;
                }
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comment}");
                Console.WriteLine("</div>");

                comment = Console.ReadLine();
            }
        }
    }
}
