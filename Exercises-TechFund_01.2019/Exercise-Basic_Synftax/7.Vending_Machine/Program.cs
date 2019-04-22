using System;

namespace _7.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double coins = 0;
            double coinsSum = 0;
           
            while (input != "Start")
            {
                coins = double.Parse(input);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    coinsSum += coins;
                }

                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                input = Console.ReadLine();
            }

            string order = Console.ReadLine().ToLower();

            double price = 0;

            while (order != "end")
            {
                switch (order)
                {
                    case "coke":
                        price = 1.0;

                        break;

                    case "crisps":
                        price = 1.5;

                        break;

                    case "nuts":
                        price = 2.0;

                        break;

                    case "soda":
                        price = 0.8;

                        break;

                    case "water":
                        price = 0.7;

                        break; 

                    default:
                        Console.WriteLine("Invalid product");

                        break;
                }

                if (order == "coke" || order == "crisps" || order == "nuts" || order == "soda" || order == "water")
                {
                    if (coinsSum >= price)
                    {
                        Console.WriteLine($"Purchased {order}");

                        coinsSum -= price;
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                order = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Change: {coinsSum:F2}");
        }
    }
}
