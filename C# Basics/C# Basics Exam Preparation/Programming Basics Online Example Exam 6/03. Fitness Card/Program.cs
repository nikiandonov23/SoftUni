using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double startMoney = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double price = 0;
            string currentSport = "";
            if (gender=="m")
            {
                switch (sport)
                {
                    case "Gym":

                        price += 42;
                        currentSport = "Gym";
                        break;
                    case "Boxing":

                        price += 41;
                        currentSport = "Boxing";

                        break;
                    case "Yoga":

                        price += 45;
                        currentSport = "Yoga";

                        break;
                    case "Zumba":

                        price += 34;
                        currentSport = "Zumba";

                        break;
                    case "Dances":

                        price += 51;
                        currentSport = "Dances";

                        break;
                    case "Pilates":

                        price += 39;
                        currentSport = "Pilates";

                        break;
                }
            }
            if (gender == "f")
            {
                switch (sport)
                {
                    case "Gym":

                        price += 35;
                        currentSport = "Gym";

                        break;
                    case "Boxing":

                        price += 37;
                        currentSport = "Boxing";

                        break;
                    case "Yoga":

                        price += 42;
                        currentSport = "Yoga";

                        break;
                    case "Zumba":

                        price += 31;
                        currentSport = "Zumba";

                        break;
                    case "Dances":

                        price += 53;
                        currentSport = "Dances";

                        break;
                    case "Pilates":

                        price += 37;
                        currentSport = "Pilates";

                        break;
                }
            }
            if (age<=19)
            {
                price *= 0.80;
            }
            if (startMoney >= price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {currentSport}.");
            }
            if (startMoney<price)
            {
                Console.WriteLine($"You don't have enough money! You need ${price-startMoney:f2} more.");
            }
            
        }
    }
}
