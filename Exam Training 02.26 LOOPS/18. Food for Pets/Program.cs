using System;

namespace _18._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            Double totalFood = Double.Parse(Console.ReadLine());

            Double bisquits = 0;
            Double totalFoodEatenfromDog = 0;
            Double totalFoodEatenfromCat = 0;



            for (int i = 1; i <= days; i++)
            {
                Double dogFoodEaten = Double.Parse(Console.ReadLine());
                totalFoodEatenfromDog += dogFoodEaten;
                Double catFoodEaten = Double.Parse(Console.ReadLine());
                totalFoodEatenfromCat += catFoodEaten;

                if (i % 3 == 0)
                {
                    bisquits += (dogFoodEaten + catFoodEaten)*0.1;
                }

            }
            Double totalFoodEaterProcent = (totalFoodEatenfromDog + totalFoodEatenfromCat) * 100 / totalFood;
            Double totalFoodEatenFromDogProcent = (totalFoodEatenfromDog*100/(totalFoodEatenfromDog+totalFoodEatenfromCat));
            Double totalFoodEatenFromCatProcent = (totalFoodEatenfromCat*100/(totalFoodEatenfromCat+totalFoodEatenfromDog));

            Console.WriteLine($"Total eaten biscuits: {Math.Round(bisquits)}gr.");
            Console.WriteLine($"{totalFoodEaterProcent:f2}% of the food has been eaten.");
            Console.WriteLine($"{totalFoodEatenFromDogProcent:f2}% eaten from the dog.");
            Console.WriteLine($"{totalFoodEatenFromCatProcent:f2}% eaten from the cat.");
            

        }
    }
}
