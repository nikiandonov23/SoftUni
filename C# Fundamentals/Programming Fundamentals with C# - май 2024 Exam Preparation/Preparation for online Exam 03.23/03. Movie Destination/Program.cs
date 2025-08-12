using System;

namespace _03._Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            double daysCount = double.Parse(Console.ReadLine());

            double price = 0;

            if (season== "Winter")
            {
                switch (destination)
                {
                    case "Dubai":
                        price = 45000*daysCount;
                        break;

                    case "Sofia":
                        price = 17000 * daysCount;
                        break;

                    case "London":
                        price = 24000 * daysCount;  
                        break;
                }
            }
            if (season == "Summer")
            {
                switch (destination)
                {
                    case "Dubai":
                        price = 40000 * daysCount;
                        break;

                    case "Sofia":
                        price = 12500 * daysCount;
                        break;

                    case "London":
                        price = 20250 * daysCount;
                        break;
                }
            }

            if (destination== "Dubai")
            {
                price *= 0.70;
            }
            if (destination== "Sofia")
            {
                price *= 1.25;
            }
            if (price<=budget)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget-price:f2} leva left!");
            }
            if (price>budget)
            {
                Console.WriteLine($"The director needs {price-budget:f2} leva more!");
            }
        }
    }
}
