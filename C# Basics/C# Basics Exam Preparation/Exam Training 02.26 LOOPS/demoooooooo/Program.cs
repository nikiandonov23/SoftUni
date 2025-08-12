using System;

class hello
{
    static void Main()
    {

        Double budget = Double.Parse(Console.ReadLine());
        int nightsStay = int.Parse(Console.ReadLine());
        Double pricePerNight = Double.Parse(Console.ReadLine());
        Double procentExtraExpenses = Double.Parse(Console.ReadLine());

        Double nightSum = 0;

        if (nightsStay > 7)
        {
            pricePerNight = pricePerNight - (pricePerNight * 5 / 100);
        }
        nightSum = nightsStay * pricePerNight + budget * procentExtraExpenses / 100;

        if (nightSum<=budget)
            Console.WriteLine($"Ivanovi will be left with {budget-nightSum:f2} leva after vacation.");
        else
            Console.WriteLine($"{nightSum-budget:f2} leva needed.");


    }
}
