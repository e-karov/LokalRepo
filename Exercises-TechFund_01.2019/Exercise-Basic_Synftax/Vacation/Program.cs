using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine().ToLower();
            string weekday = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            switch (weekday.ToLower())
            {
                case "friday":

                    switch (typeOfGroup)
                    {
                        case "students":
                            price = 8.45;

                            break;

                        case "business":
                            price = 10.90;
                            break;

                        case "regular":
                            price = 15;
                            break;
                            
                    }

                    break;

                case "saturday":

                    switch (typeOfGroup.ToLower())
                    {
                        case "students":
                            price = 9.80;
                            break;

                        case "business":
                            price = 15.60;
                            break;

                        case "regular":
                            price = 20;
                            break;

                    }

                    break;

                case "sunday":

                    switch (typeOfGroup.ToLower())
                    {
                        case "students":
                            price = 10.46;
                            break;

                        case "business":
                            price = 16;
                            break;

                        case "regular":
                            price = 22.50;
                            break;

                    }

                    break;

            }

            if (typeOfGroup == "business" && guestsCount >= 100)
            {
                guestsCount -= 10;
            }

            totalPrice = price * guestsCount;

            if (typeOfGroup == "students" && guestsCount >= 30)
            {
                totalPrice *=  0.85;
            }

            if (typeOfGroup == "regular" && (guestsCount >= 10 && guestsCount <= 20))
            {
                totalPrice *= 0.95; 
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
