using System;

namespace fghgj
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string datesOfTrip = Console.ReadLine();
            int numberOfDays = int.Parse(Console.ReadLine());

            int priceSum = 0;

            if (destination == "France")
            {
                switch (datesOfTrip)
                {
                    case "21-23":
                        priceSum += 30 * numberOfDays;

                        break;
                    case "24-27":
                        priceSum += 35 * numberOfDays;
                        break;
                    case "28-31":
                        priceSum += 40 * numberOfDays;
                        break;


                }
            }
            if (destination == "Italy")
            {
                switch (datesOfTrip)
                {
                    case "21-23":
                        priceSum += 28 * numberOfDays;

                        break;
                    case "24-27":
                        priceSum += 32 * numberOfDays;
                        break;
                    case "28-31":
                        priceSum += 39 * numberOfDays;
                        break;


                }
            }
            if (destination == "Germany")
            {
                switch (datesOfTrip)
                {
                    case "21-23":
                        priceSum += 32 * numberOfDays;

                        break;
                    case "24-27":
                        priceSum += 37 * numberOfDays;
                        break;
                    case "28-31":
                        priceSum += 43 * numberOfDays;
                        break;


                }
            }
            Console.WriteLine($"Easter trip to {destination} : {priceSum:f2} leva.");
        }
    }
}
