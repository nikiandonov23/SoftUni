using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            Double count = Double.Parse(Console.ReadLine());
            Double priceOfTheFruits = 0;

             if (fruit == "banana")
            {
                if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                {
                    priceOfTheFruits = count * 2.50;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }
                else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                {
                    priceOfTheFruits = count * 2.70;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }

            }



            else if (fruit == "apple")
            {
                if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                {
                    priceOfTheFruits = count * 1.20;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }
                else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                {
                    priceOfTheFruits = count * 1.25;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }

            }




            else if (fruit == "orange")
            {
                if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                {
                    priceOfTheFruits = count * 0.85;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }
                else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                {
                    priceOfTheFruits = count * 0.90;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }

            }


            else if (fruit == "grapefruit")
            {
                if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                {
                    priceOfTheFruits = count * 1.45;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }
                else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                {
                    priceOfTheFruits = count * 1.60;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }

            }


            else if (fruit == "kiwi")
            {
                if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                {
                    priceOfTheFruits = count * 2.70;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }
                else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                {
                    priceOfTheFruits = count * 3.00;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }

            }


            else if (fruit == "pineapple")
            {
                if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                {
                    priceOfTheFruits = count * 5.50;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }
                else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                {
                    priceOfTheFruits = count * 5.60;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }

            }


            else if (fruit == "grapes")
            {
                if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                {
                    priceOfTheFruits = count * 3.85;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }
                else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                {
                    priceOfTheFruits = count * 4.20;
                    Console.WriteLine($"{priceOfTheFruits:f2}");
                }

            }
            else
                Console.WriteLine("error");

        







        }
    }
}
