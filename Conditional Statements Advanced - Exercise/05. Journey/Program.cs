using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            Double budget = Double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string typeOfHotel = "";
            string destination = "";
            Double moneySpent = 0;

            //· При 100лв. или по-малко – някъде в България
            // o Лято – 30 % от бюджета
            //o Зима – 70 % от бюджета

            //· При 1000лв.или по малко – някъде на Балканите
            //o Лято – 40 % от бюджета
            //o Зима – 80 % от бюджета

            //· При повече от 1000лв. – някъде из Европа
            //o При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")

                {
                    typeOfHotel = "Camp";
                    moneySpent = budget * 0.30;
                }
                if (season == "winter")
                {
                    typeOfHotel = "Hotel";

                    moneySpent = budget * 0.70;
                }


            }
            if ((budget <= 1000)&&(budget>100))
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    typeOfHotel = "Camp";

                    moneySpent = budget * 0.40;
                }
                if (season == "winter")
                {
                    typeOfHotel = "Hotel";

                    moneySpent = budget * 0.80;
                }
            }
            if (budget > 1000)
            {
                typeOfHotel = "Hotel";

                destination = "Europe";
                moneySpent = budget * 0.90;
            }
            

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfHotel} - {moneySpent:f2}");

        }
    }
}
