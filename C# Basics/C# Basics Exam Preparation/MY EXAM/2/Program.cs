using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());    //v KG
            double firstDailyFood = double.Parse(Console.ReadLine());
            double secondDailyFood = double.Parse(Console.ReadLine());
            double thirdDailyFood = double.Parse(Console.ReadLine());

            double totalFoodEaten = (firstDailyFood + secondDailyFood + thirdDailyFood) * days;

            if (foodLeft>=totalFoodEaten)
            {
                Console.WriteLine($"{Math.Floor(foodLeft-totalFoodEaten)} kilos of food left.");
            }
            if (foodLeft<totalFoodEaten)
            {
                Console.WriteLine($"{Math.Ceiling(totalFoodEaten-foodLeft)} more kilos of food are needed.");
            }


        }
    }
}
