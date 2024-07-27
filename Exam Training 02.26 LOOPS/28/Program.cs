using System;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberClients = int.Parse(Console.ReadLine());
            Double basket = 1.50;
            Double wreath = 3.80;
            Double chocolateBunny = 7;
            Double productsCount = 0;
            Double totalPrice = 0;
            Double avarageSum = 0;
            Double savedPrice = 0;





            for (int i = 1; i <= numberClients; i++)
            {
                string comand = Console.ReadLine();

                while (comand != "Finish")
                {


                    if (comand == "basket")
                    {
                        totalPrice += basket;
                        productsCount += 1;
                    }
                    if (comand == "wreath")
                    {
                        totalPrice += wreath;
                        productsCount += 1;
                    }
                    if (comand == "chocolate bunny")
                    {
                        totalPrice += chocolateBunny;
                        productsCount += 1;
                    }
                    comand = Console.ReadLine();


                    if (comand == "Finish")
                    {
                        if (productsCount % 2 == 0)
                        {
                            totalPrice *= 0.80;
                        }
                        Console.WriteLine($"You purchased {productsCount} items for {totalPrice:f2} leva.");
                        savedPrice +=totalPrice;
                        totalPrice = 0;
                        productsCount = 0;
                    }

                }


            }

            avarageSum = savedPrice / numberClients;
            Console.WriteLine($"Average bill per client is: {avarageSum:f2} leva.");




        }
    }
}
