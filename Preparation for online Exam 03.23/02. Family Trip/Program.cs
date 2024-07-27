using System;

namespace _02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            double procentExtraExpenses = double.Parse(Console.ReadLine());

            if (nights > 7)
            {
                pricePerNight *= 0.95;
            }
            double extraExpenses = budget * procentExtraExpenses / 100;
            double totalMoney = pricePerNight * nights + extraExpenses;

            if (totalMoney > budget)
            {
                Console.WriteLine($"{totalMoney - budget:f2} leva needed.");
            }
            if (totalMoney <= budget)
            {

                Console.WriteLine($"Ivanovi will be left with {budget - totalMoney:f2} leva after vacation.");
            }
        }
    }
}
