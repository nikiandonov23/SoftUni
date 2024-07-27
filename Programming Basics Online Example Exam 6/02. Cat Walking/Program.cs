using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalk = int.Parse(Console.ReadLine());           //za 1min gori po 5 kalorii
            int numberOfWalks = int.Parse(Console.ReadLine());
            int caloriesEaten = int.Parse(Console.ReadLine());



            int totalCaloriesBurned = minutesWalk * 5 * numberOfWalks;

            if (totalCaloriesBurned>=caloriesEaten/2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCaloriesBurned}.");
            }
            if (totalCaloriesBurned<caloriesEaten/2)
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCaloriesBurned}.");
            }
        }
    }
}
