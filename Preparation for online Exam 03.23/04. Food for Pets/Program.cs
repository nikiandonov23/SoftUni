using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double startFood = double.Parse(Console.ReadLine());

            double counterBisquits = 0;
            double biscuitsInGrams = 0;

            double dogTotal = 0;
            double catTotal = 0;

            double totalEatenFood = 0;

            for (int i = 1; i <= days; i++)             //vurti dnite
            {
                double eatenDaily = 0;

                double eatenFromDog = double.Parse(Console.ReadLine());
                dogTotal += eatenFromDog;

                double eatenFromCat = double.Parse(Console.ReadLine());
                catTotal += eatenFromCat;

                eatenDaily = eatenFromDog + eatenFromCat;

                if (i%3==0)
                {
                    counterBisquits++;
                    biscuitsInGrams += eatenDaily * 0.1;

                }
                totalEatenFood += eatenDaily;
            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuitsInGrams)}gr.");
            Console.WriteLine($"{(dogTotal+catTotal)/startFood*100:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogTotal/totalEatenFood*100:f2}% eaten from the dog.");
            Console.WriteLine($"{catTotal/totalEatenFood*100:f2}% eaten from the cat.");

        }
    }
}
