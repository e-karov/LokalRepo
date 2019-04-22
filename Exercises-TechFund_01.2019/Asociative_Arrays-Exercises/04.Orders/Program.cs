using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders                // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string input = "";
            Dictionary<string, double> productsPrices = new Dictionary<string, double>();
            Dictionary<string, int> productsQuantities = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] inputLine = input.Split();
                string product = inputLine[0];
                double price = double.Parse(inputLine[1]);
                int quantity = int.Parse(inputLine[2]);

                if (productsPrices.ContainsKey(product) == false)
                {
                    productsPrices.Add(product, price);
                    productsQuantities.Add(product, 0);
                }

                productsPrices[product] = price;
                productsQuantities[product] += quantity;
            }

            foreach (var product in productsPrices)
            {
                double totalPrice = product.Value * productsQuantities[product.Key];

                Console.WriteLine($"{product.Key} -> {totalPrice:F2}");
            }
        }
    }
}
