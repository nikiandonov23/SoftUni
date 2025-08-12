using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numPaper = double.Parse(Console.ReadLine());
            double numPlat = double.Parse(Console.ReadLine());
            double numLepipo = double.Parse(Console.ReadLine());
            double procentDiscount = double.Parse(Console.ReadLine());

            double pricePaper = 5.80 * numPaper;
            double pricePlat = 7.20 * numPlat;
            double priceLepilo = 1.20 * numLepipo;

            double totalSum = pricePaper + pricePlat + priceLepilo;
            double finalSum = totalSum - (totalSum * procentDiscount / 100);
            Console.WriteLine($"{finalSum:f3}");




        }
    }
}
