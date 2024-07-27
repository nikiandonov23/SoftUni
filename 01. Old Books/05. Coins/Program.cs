using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            Double number = Double.Parse(Console.ReadLine());   //2,73

            int coinsCount = 0;

            Double change = number * 100;
            while (change >=1)
            {
                coinsCount++;
                if (change >= 200)
                {
                    change -= 200;
                }
                else if (change >= 100)
                {
                    change -= 100;
                }
                else if (change >= 50)
                {
                    change -= 50;
                }
                else if (change >= 20)
                {
                    change -= 20;
                }
                else if (change >= 10)
                {
                    change -= 10;
                }
                else if (change >= 5)
                {
                    change -= 5;
                }
                else if (change >= 2)
                {
                    change -= 2;
                }
                else
                {
                    change = 0;
                }
              



            }
            Console.WriteLine(coinsCount);


        }



    }
}

