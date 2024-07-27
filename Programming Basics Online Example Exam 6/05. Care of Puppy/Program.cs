using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodBuyed = double.Parse(Console.ReadLine());
            double foodBuyedInGrams = foodBuyed * 1000;

            string input = Console.ReadLine();

            double totalFoodEaten = 0;

            while (input!= "Adopted")
            {
                double inputAsNumber = double.Parse(input);
                totalFoodEaten += inputAsNumber;


                
                input = Console.ReadLine();
            }
            if ((input== "Adopted")&&(totalFoodEaten<=foodBuyedInGrams))
                Console.WriteLine($"Food is enough! Leftovers: {foodBuyedInGrams-totalFoodEaten} grams.");
            if (totalFoodEaten > foodBuyedInGrams)
            {
                Console.WriteLine($"Food is not enough. You need {totalFoodEaten - foodBuyedInGrams} grams more.");
            }


        }
    }
}
