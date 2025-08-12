using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ред 1.Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            //Ред 2.Брой на статистите – цяло число в интервала[1 … 500]
            //Ред 3.Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]

            //· Декорът за филма е на стойност 10 % от бюджета.
            //· При повече от 150 статиста, има отстъпка за облеклото на стойност 10 %.


            Double budget = Double.Parse(Console.ReadLine());
            int statistCount = int.Parse(Console.ReadLine());
            Double priceWear = Double.Parse(Console.ReadLine());

            Double decorPrice = budget * 0.1;
            if (statistCount > 150)
            {
                priceWear = priceWear - (priceWear * 0.1);
            }

            Double totalMoviePrice = statistCount * priceWear + decorPrice;


            if (totalMoviePrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalMoviePrice - budget:f2} leva more.");
            }

            else if (totalMoviePrice <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalMoviePrice:f2} leva left.");
            }
        }
    }
}
