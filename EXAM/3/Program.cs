using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberDancers = double.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double moneyWinned = 0;

            if (place == "Abroad")
            {
                moneyWinned = numberDancers * points + (numberDancers * points * 0.50);

                switch (season)
                {
                    case "summer":
                        moneyWinned = moneyWinned * 0.90;
                        break;


                    case "winter":
                        moneyWinned = moneyWinned * 0.85;

                        break;
                }
            }
            if (place == "Bulgaria")
            {
                moneyWinned = numberDancers * points ;


                switch (season)
                {
                    case "summer":
                        moneyWinned = moneyWinned * 0.95;
                        break;


                    case "winter":
                        moneyWinned = moneyWinned * 0.92;

                        break;
                }
            }
            double charityTax = moneyWinned * 0.75;
            Console.WriteLine($"Charity - {charityTax:f2}");
            Console.WriteLine($"Money per dancer - {(moneyWinned- charityTax) /numberDancers:f2}");

        }
    }
}
