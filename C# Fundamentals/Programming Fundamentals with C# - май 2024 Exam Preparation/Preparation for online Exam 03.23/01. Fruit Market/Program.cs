using System;

namespace _01._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberry = double.Parse(Console.ReadLine());         //lv
            double amauntBananas = double.Parse(Console.ReadLine());
            double amauntOrange = double.Parse(Console.ReadLine());
            double amauntMalini = double.Parse(Console.ReadLine());
            double amauntStrawberry = double.Parse(Console.ReadLine());     //kg

            double priceMalini = priceStrawberry / 2;
            double priceOrange = priceMalini * 0.60;
            double priceBanana = priceMalini * 0.20;

            double totalPrice = priceStrawberry * amauntStrawberry + priceMalini * amauntMalini + priceOrange * amauntOrange + priceBanana * amauntBananas;

            Console.WriteLine($"{totalPrice:f2}");




        }
    }
}
