using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberBitcoins = int.Parse(Console.ReadLine());//1
            double chinese = double.Parse(Console.ReadLine());//5
            double comission = double.Parse(Console.ReadLine());  //5%        //v PROCENTI
            

            //• 1 биткойн = 1168 лева.
            //• 1 китайски юан = 0.15 долара.
            //• 1 долар = 1.76 лева.
            //• 1 евро = 1.95 лева.

            double bitcoinPrice = numberBitcoins * 1168;  //LEVA
            double chinesePriceInLEVA = chinese * 0.15*1.76;      //LEVA

            double totalPriceInLeva = bitcoinPrice + chinesePriceInLEVA;
            double totalPriceInEuro = totalPriceInLeva / 1.95;
            double comissionProcent = comission / 100;
            double priceAfterComission = totalPriceInEuro - (totalPriceInEuro * comissionProcent);

            Console.WriteLine($"{priceAfterComission:f2}");
           
            
        }
    }
}
