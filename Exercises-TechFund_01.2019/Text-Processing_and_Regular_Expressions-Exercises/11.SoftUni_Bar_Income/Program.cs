using System;
using System.Text.RegularExpressions;

namespace _11.SoftUni_Bar_Income            // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"%(?<name>[A-Z{1][a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<count>\d+)\|[^|$%.]*?(?<price>(\+|-)?\d+[.]?\d*)\$";
            double totalIncome = 0;

            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string custumer = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    totalIncome += (price * count);

                    Console.WriteLine($"{custumer}: {product} - {(price*count):F2}");
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
