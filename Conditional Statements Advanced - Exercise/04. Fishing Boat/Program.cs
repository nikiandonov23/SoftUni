using System;

class hello
{
    static void Main()
    {
        Double budget = Double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        Double fishermanCount = Double.Parse(Console.ReadLine());

        Double priceBoat = 0;

        if (season == "Spring")
        {
            priceBoat = 3000;
        }
        if (season == "Summer" || season == "Autumn")
        {
            priceBoat = 4200;
        }
        if (season == "Winter")
        {
            priceBoat = 2600;
        }
        if (fishermanCount <= 6)
        {
            priceBoat *= 0.90;
        }
        if ((fishermanCount >= 7) && (fishermanCount <= 11))
        {
            priceBoat *= 0.85;
        }
        if (fishermanCount > 12)
        {
            priceBoat *= 0.75;
        }
        if (season != "Autumn" && fishermanCount % 2 == 0)
        {
            priceBoat *= 0.95;
        }
        if (budget >= priceBoat)
        {
            Console.WriteLine($"Yes! You have {budget - priceBoat:f2} leva left.");
        }
        if (budget < priceBoat)
        {
            Console.WriteLine($"Not enough money! You need {priceBoat - budget:f2} leva.");
        }
    }
}
