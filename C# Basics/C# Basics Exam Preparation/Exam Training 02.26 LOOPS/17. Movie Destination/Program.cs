using System;

namespace _17._Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            Double budget = Double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());

            Double filmingDayPrice = 0;

            if (season == "Winter")
            {
                switch (destination)
                {
                    case "Dubai":
                        filmingDayPrice += 45000 * daysCount;
                        break;
                    case "Sofia":
                        filmingDayPrice += 17000 * daysCount;
                        break;
                    case "London":
                        filmingDayPrice += 24000 * daysCount;
                        break;


                }


            }
            if (season == "Summer")
            {
                {
                    switch (destination)
                    {
                        case "Dubai":
                            filmingDayPrice += 40000 * daysCount;
                            break;
                        case "Sofia":
                            filmingDayPrice += 12500 * daysCount;
                            break;
                        case "London":
                            filmingDayPrice += 20250 * daysCount;
                            break;


                    }
                }
            }
            if (destination == "Dubai")
            {
                filmingDayPrice *= 0.70;

            }
            if (destination == "Sofia")
            {
                filmingDayPrice *= 1.25;

            }
            if (budget>=filmingDayPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget-filmingDayPrice:f2} leva left!");
            }
            if (budget < filmingDayPrice)
            {
                Console.WriteLine($"The director needs {filmingDayPrice-budget:f2} leva more!");
            }
        }
    }
}
