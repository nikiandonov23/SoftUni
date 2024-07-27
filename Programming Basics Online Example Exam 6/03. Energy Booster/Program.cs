using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string gelTaste = Console.ReadLine();
            string gelPack = Console.ReadLine();
            double numberPacks = double.Parse(Console.ReadLine());


            double smallGelPrice = 0;
            double bigGelPrice = 0;


            if (gelPack == "small")
            {
                switch (gelTaste)
                {

                    case "Watermelon":
                        smallGelPrice += 56 * 2;

                        break;
                    case "Mango":
                        smallGelPrice += 36.66 * 2;


                        break;
                    case "Pineapple":
                        smallGelPrice += 42.10 * 2;


                        break;
                    case "Raspberry":
                        smallGelPrice += 20 * 2;


                        break;
                }
                
            }
            if (gelPack == "big")
            {
                switch (gelTaste)
                {

                    case "Watermelon":
                        bigGelPrice += 28.70 * 5;

                        break;
                    case "Mango":
                        bigGelPrice += 19.60 * 5;


                        break;
                    case "Pineapple":
                        bigGelPrice += 24.80 * 5;


                        break;
                    case "Raspberry":
                        bigGelPrice += 15.20 * 5;


                        break;
                }
            }
            double totalGelPrice = (smallGelPrice + bigGelPrice) * numberPacks;

            if (totalGelPrice<400)
            {
                Console.WriteLine($"{totalGelPrice:f2} lv.");
            }
            if ((totalGelPrice >= 400) && (totalGelPrice <= 1000))
            {
                totalGelPrice *= 0.85;
                Console.WriteLine($"{totalGelPrice:f2} lv.");


            }
            if (totalGelPrice>1000)
            {
                totalGelPrice *= 0.50;
                Console.WriteLine($"{totalGelPrice:f2} lv.");

            }
        }
    }
}
