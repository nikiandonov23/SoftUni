using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            //град / продукт coffee water beer     sweets     peanuts

            //Sofia           0.50  0.80   1.20     1.45      1.60

            //Plovdiv         0.40  0.70   1.15     1.30      1.50

            //Varna           0.45  0.70   1.10     1.35      1.55


            string bevarage = Console.ReadLine();
            string city = Console.ReadLine();
            Double count = Double.Parse(Console.ReadLine());
            Double priceOfBevarage = 0;
            if (bevarage == "coffee")
            {
                if (city == "Sofia")
                {
                    priceOfBevarage = 0.50 * count;
                    Console.WriteLine(priceOfBevarage);
                }
                else if (city == "Plovdiv")
                {
                    priceOfBevarage = 0.40 * count;
                    Console.WriteLine(priceOfBevarage);
                }
                else if (city == "Varna")
                {
                    priceOfBevarage = 0.45 * count;
                    Console.WriteLine(priceOfBevarage);
                }

            }
            else if (bevarage == "water")
            {
                if (city == "Sofia")
                {
                    priceOfBevarage = 0.80 * count;
                    Console.WriteLine(priceOfBevarage);
                }
                else if (city == "Plovdiv")
                {
                    priceOfBevarage = 0.70 * count;
                    Console.WriteLine(priceOfBevarage);
                }
                else if (city == "Varna")
                {
                    priceOfBevarage = 0.7 * count;
                    Console.WriteLine(priceOfBevarage);
                }

            }
            else if (bevarage == "beer")
            {
                if (city == "Sofia")
                {
                    priceOfBevarage = 1.20 * count;
                    Console.WriteLine(priceOfBevarage);
                }
                else if (city == "Plovdiv")
                {
                    priceOfBevarage = 1.15 * count;
                    Console.WriteLine(priceOfBevarage);
                }
                else if (city == "Varna")
                {
                    priceOfBevarage = 1.10 * count;
                    Console.WriteLine(priceOfBevarage);
                }

            }


            else if (bevarage == "sweets")
            {
                if (city == "Sofia")
                {
                    priceOfBevarage = 1.45 * count;
                    Console.WriteLine(priceOfBevarage);
                }
                else if (city == "Plovdiv")
                {
                    priceOfBevarage = 1.30 * count;
                    Console.WriteLine(priceOfBevarage);
                }
                else if (city == "Varna")
                {
                    priceOfBevarage = 1.35 * count;
                    Console.WriteLine(priceOfBevarage);
                }

            }

            else if (bevarage == "peanuts")
            {
                if (city == "Sofia")
                {
                    priceOfBevarage = 1.60 * count;
                    Console.WriteLine(priceOfBevarage);
                }
                else if (city == "Plovdiv")
                {
                    priceOfBevarage = 1.50 * count;
                    Console.WriteLine(priceOfBevarage);
                }
                else if (city == "Varna")
                {
                    priceOfBevarage = 1.55 * count;
                    Console.WriteLine(priceOfBevarage);
                }

            }





        }
    }
}
