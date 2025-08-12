using System;

namespace _26._02._Easter_Guests
{
    class Program
    {
        static void Main(string[] args)                                                  // Един козунак струва 4лв.
                                                                                         // Едно яйце струва 0.45лв.
        {
            Double numberGuests = Double.Parse(Console.ReadLine());
            Double budget = Double.Parse(Console.ReadLine());

            Double bakePrice = 4;
            Double eggPrice = 0.45;

            Double numberBakesNeeded = Math.Ceiling(numberGuests / 3);
            Double numberEggsNeeded = numberGuests *2;

            Double moneySum = numberBakesNeeded * bakePrice+numberEggsNeeded*eggPrice;

            if (budget >= moneySum)
            {
                Console.WriteLine($"Lyubo bought {numberBakesNeeded} Easter bread and {numberEggsNeeded} eggs.");
                Console.WriteLine($"He has {budget-moneySum:f2} lv. left.");
            }
            if (budget < moneySum)
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {moneySum-budget:f2} lv. more.");
            }
            
        }
    }
}
