using System;

namespace _24._01._Easter_Bakery
{
    class Program
    {
        static void Main(string[] args)                                      // цената на килограм захар е с 25% по-ниска от тази на килограм брашно
                                                                             // цената на една кора с яйца е с 10% по-висока от цената на килограм брашно
                                                                             // цената на един пакет мая е с 80% по-ниска от цената на килограм захар
        {
            Double flourPrice = Double.Parse(Console.ReadLine());                 //1.Цена на брашното за един килограм – реално число в интервала [0.00 … 10000.00]
            Double flourKg = Double.Parse(Console.ReadLine());                    //2.Килограми на брашното – реално число в интервала[0.00 … 10000.00]
            Double sugarKg = Double.Parse(Console.ReadLine());                    //3.Килограми на захарта – реално число в интервала[0.00 … 10000.00]
            Double eggsPacks = Double.Parse(Console.ReadLine());                  //4.Брой кори с яйца – цяло число в интервала[0 … 10000]
            Double maiaPacks = Double.Parse(Console.ReadLine());                  //5.Пакети мая – цяло число в интервала[0 … 10000

            Double totalPriceFlour = flourPrice*flourKg;
            Double totalPriceSugar = flourPrice*0.75*sugarKg;
            Double totalPriceEggs = flourPrice*1.1*eggsPacks;
            Double totalPriceMaia = (flourPrice*0.75)*0.20*maiaPacks;

            Double sum = totalPriceFlour + totalPriceSugar + totalPriceEggs + totalPriceMaia;
            Console.WriteLine($"{sum:f2}");



        }
    }
}
