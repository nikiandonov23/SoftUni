using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)                                                              ////§ "room for one person" – 18.00 лв за нощувка (no discount)
                                                                                                     ////§ "apartment" – 25.00 лв за нощувка (<10 -30%,10-15-35%,>15-50%)
                                                                                                     ////§ "president apartment" – 35.00 лв за нощувка (<10 -10%,10-15-15%,>15-20%)
        {
            int daysOfStayEntry = int.Parse(Console.ReadLine());
            string typeOfProperty = Console.ReadLine();
            string evaluation = Console.ReadLine();
            int daysOfStay = daysOfStayEntry - 1;
            Double price = 0;
            Double finalPrice = 0;

            if (daysOfStay<10)

            switch (typeOfProperty)
            {
                case "room for one person":
                    price =18*daysOfStay;
                    break;
                case "apartment":
                    price = (25.00 * daysOfStay)*070;
                    break;
                case "president apartment":
                    price = (35.00 * daysOfStay)*0.90;
                    break;                 
            }
            if ((daysOfStay >= 10) && (daysOfStay <= 15))
            {
                switch (typeOfProperty)
                {
                    case "room for one person":
                        price = 18 * daysOfStay;
                        break;
                    case "apartment":
                        price = (25.00 * daysOfStay) * 0.65;
                        break;
                    case "president apartment":
                        price = (35.00 * daysOfStay) * 0.85;
                        break;
                }
            }
            else if (daysOfStay > 15)
            {
                {
                    switch (typeOfProperty)
                    {
                        case "room for one person":
                            price = 18 * daysOfStay;
                            break;
                        case "apartment":
                            price = (25.00 * daysOfStay) * 0.50;
                            break;
                        case "president apartment":
                            price = (35.00 * daysOfStay) * 0.80;
                            break;
                    }
                }
            }

            if (evaluation == "positive")
            {
                finalPrice = price + (price * 0.25);
                Console.WriteLine($"{finalPrice:f2}");
            }
            else if (evaluation == "negative")
            {
                finalPrice = price - (price * 0.10);
                Console.WriteLine($"{finalPrice:f2}");

            }
        }
    }
}
