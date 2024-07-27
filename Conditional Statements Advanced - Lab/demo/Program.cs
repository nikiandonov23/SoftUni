using System;

class hello
{
    static void Main()
    {
        string fruit = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        double count = Double.Parse(Console.ReadLine());

        Double priceOfTheFruits = 0.0;

        if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
        {
            switch (fruit)
            {
                case "banana":
                    priceOfTheFruits = count * 2.50;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                case "apple":
                    priceOfTheFruits = count * 1.20;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                case "orange":
                    priceOfTheFruits = count * 0.85;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                case "grapefruit":
                    priceOfTheFruits = count * 1.45;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                case "kiwi":
                    priceOfTheFruits = count * 2.70;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                case "pineapple":
                    priceOfTheFruits = count * 5.50;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                case "grapes":
                    priceOfTheFruits = count * 3.85;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }


        }
        else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
        {
            switch (fruit)
            {
                case "banana":
                    priceOfTheFruits = count * 2.70;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                case "apple":
                    priceOfTheFruits = count * 1.25;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                case "orange":
                    priceOfTheFruits = count * 0.90;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                case "grapefruit":
                    priceOfTheFruits = count * 1.60;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                case "kiwi":
                    priceOfTheFruits = count * 3.00;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                case "pineapple":
                    priceOfTheFruits = count * 5.60;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                case "grapes":
                    priceOfTheFruits = count * 4.20;
                    Console.WriteLine($"{ priceOfTheFruits:f2}");
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }


        }








        else
            Console.WriteLine("error");


    }
}
