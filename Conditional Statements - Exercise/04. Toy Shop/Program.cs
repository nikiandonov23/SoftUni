using System;

namespace demoo
{
    class Program
    {
        static void Main(string[] args)
        {


            Double tourPrice = Double.Parse(Console.ReadLine());
            int puzzlesCout = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            int sumOfToysCount = puzzlesCout + dollsCount + bearsCount + minionsCount + trucksCount;

            Double sumOfToysMoney = puzzlesCout * 2.6 + dollsCount * 3 + bearsCount * 4.1 + minionsCount * 8.2 + trucksCount * 2;
            if (sumOfToysCount >= 50)
            {
                sumOfToysMoney = sumOfToysMoney - (sumOfToysMoney * 0.25);
            }
            Double profit = sumOfToysMoney - sumOfToysMoney * 0.1;
            if (profit >= tourPrice)
            {
                Console.WriteLine($"Yes! {profit - tourPrice:f02} lv left.");
            }
            else if (profit < tourPrice)
            {
                Console.WriteLine($"Not enough money! {tourPrice - profit:f02} lv needed.");
            }



        }
    }
}
