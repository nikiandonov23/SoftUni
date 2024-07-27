using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            Double aparmtentPrice = 0;
            Double studioPrice = 0;

            if ((month == "May") || (month == "October"))
            {
                aparmtentPrice = 65 * nightsCount;
                studioPrice = 50 * nightsCount;
                if (nightsCount > 14)
                {
                    aparmtentPrice *= 0.90;
                    studioPrice *= 0.70;
                }
                if ((nightsCount > 7)&& (nightsCount<=14))               //TUK MNOGO MI GURMQ ZARADI VTOROTO USLOVIE <=14.NE MOJEH DA SE SETQ 4E TRQBVA DA KONKRETIZIRAM @@@@!!!!!!!
                {
                    studioPrice *= 0.95;
                }
            }
            else if ((month == "June") || (month == "September"))
            {
                aparmtentPrice = 68.70 * nightsCount;
                studioPrice = 75.20 * nightsCount;
                if (nightsCount > 14)
                {
                    studioPrice *= 0.80;
                    aparmtentPrice *= 0.90;

                }
            }
            else if ((month == "July") || (month == "August"))
            {
                aparmtentPrice = 77 * nightsCount;
                studioPrice = 76 * nightsCount;
                if (nightsCount > 14)
                {
                    aparmtentPrice *= 0.90;

                }


            }


            Console.WriteLine($"Apartment: {aparmtentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");


           





        }
    }
}
