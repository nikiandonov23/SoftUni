using System;

namespace _02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double laguage20kg = double.Parse(Console.ReadLine());
            double laguageAmount = double.Parse(Console.ReadLine());
            int daysTillTrip = int.Parse(Console.ReadLine());
            int laguageCount = int.Parse(Console.ReadLine());

            double actualLaguagePrice = 0;

            if (laguageAmount > 20)

            {
                actualLaguagePrice = laguage20kg;
                if (daysTillTrip > 30)
                {
                    actualLaguagePrice = actualLaguagePrice * 1.10;
                }
                if ((daysTillTrip >= 7) && (daysTillTrip <= 30))
                {
                    actualLaguagePrice = actualLaguagePrice * 1.15;

                }
                if (daysTillTrip < 7)
                {
                    actualLaguagePrice = actualLaguagePrice * 1.40;
                }



            }
            if ((laguageAmount >= 10) && (laguageAmount <= 20))
            {
                actualLaguagePrice = laguage20kg * 0.50;
                if (daysTillTrip > 30)
                {
                    actualLaguagePrice = actualLaguagePrice * 1.10;
                }
                if ((daysTillTrip >= 7) && (daysTillTrip <= 30))
                {
                    actualLaguagePrice = actualLaguagePrice * 1.15;

                }
                if (daysTillTrip < 7)
                {
                    actualLaguagePrice = actualLaguagePrice * 1.40;
                }
            }
            if (laguageAmount < 10)
            {
                actualLaguagePrice = laguage20kg * 0.20;
                if (daysTillTrip > 30)
                {
                    actualLaguagePrice = actualLaguagePrice * 1.10;
                }
                if ((daysTillTrip >= 7) && (daysTillTrip <= 30))
                {
                    actualLaguagePrice = actualLaguagePrice * 1.15;

                }
                if (daysTillTrip < 7)
                {
                    actualLaguagePrice = actualLaguagePrice * 1.40;
                }
            }
            Console.WriteLine($" The total price of bags is: {actualLaguagePrice*laguageCount:f2} lv. ");

        }
    }
}
