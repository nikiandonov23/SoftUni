using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //· Видеокарта – 250 лв./ бр.
            //· Процесор – 35 % от цената на закупените видеокарти/ бр.
            //· Рам памет – 10 % от цената на закупените видеокарти/ бр.


            Double budget = Double.Parse(Console.ReadLine());       //1.Бюджетът на Петър -реално число в интервала[0.0…100000.0]
            int videoCount = int.Parse(Console.ReadLine());         //2.Броят видеокарти - цяло число в интервала[0…100]
            int processorCount = int.Parse(Console.ReadLine());     //3.Броят процесори - цяло число в интервала[0…100]
            int ramCount = int.Parse(Console.ReadLine());           //4.Броят рам памет -цяло число в интервала[0…100]

            Double videoPrice = 250*videoCount;
            Double processorPrice = (videoPrice * 0.35)*processorCount;
            Double ramPrice = (videoPrice * 0.1)*ramCount;

            Double totalPriceAll = videoPrice + processorPrice + ramPrice;
            if (videoCount > processorCount)
                totalPriceAll = totalPriceAll - (totalPriceAll * 0.15);
            {
                if (budget >= totalPriceAll)
                    Console.WriteLine($"You have {budget - totalPriceAll:F2} leva left!");
                else
                    Console.WriteLine($"Not enough money! You need {totalPriceAll - budget:F2} leva more!");
            }


        }
    }
}
