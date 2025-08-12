using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Double kucheta = Double.Parse(Console.ReadLine());
            Double kotki = Double.Parse(Console.ReadLine());

            Double sumkucheta = kucheta * 2.5;
            Double sumkotki = kotki * 4;
            Double ednprice = sumkucheta + sumkotki;
            Console.WriteLine($"{ednprice} lv.");
            
        }
    }
}
