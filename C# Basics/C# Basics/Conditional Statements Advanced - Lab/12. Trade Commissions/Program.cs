using System;

class hello
{
    static void Main()
    {
        string city = Console.ReadLine();
        Double volumeOfSales = Double.Parse(Console.ReadLine());
        Double comission = 0.0;
        if ((volumeOfSales >= 0) && (volumeOfSales <= 500))
        {
            switch (city)
            {
                case "Sofia":
                    comission = volumeOfSales * 0.05;
                    Console.WriteLine($"{comission:f2}");
                    break;
                case "Varna":
                    comission = volumeOfSales * 0.045;
                    Console.WriteLine($"{comission:f2}");
                    break;
                case "Plovdiv":
                    comission = volumeOfSales * 0.055;
                    Console.WriteLine($"{comission:f2}");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }



        }


        else if ((volumeOfSales > 500) && (volumeOfSales <= 1000))
        {
            switch (city)
            {
                case "Sofia":
                    comission = volumeOfSales * 0.07;
                    Console.WriteLine($"{comission:f2}");
                    break;
                case "Varna":
                    comission = volumeOfSales * 0.075;
                    Console.WriteLine($"{comission:f2}");
                    break;
                case "Plovdiv":
                    comission = volumeOfSales * 0.08;
                    Console.WriteLine($"{comission:f2}");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }

        else if ((volumeOfSales > 1000) && (volumeOfSales <= 10000))
        {
            switch (city)
            {
                case "Sofia":
                    comission = volumeOfSales * 0.08;
                    Console.WriteLine($"{comission:f2}");
                    break;
                case "Varna":
                    comission = volumeOfSales * 0.1;
                    Console.WriteLine($"{comission:f2}");
                    break;
                case "Plovdiv":
                    comission = volumeOfSales * 0.12;
                    Console.WriteLine($"{comission:f2}");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
        else if (volumeOfSales > 10000)
        {
            switch (city)
            {
                case "Sofia":
                    comission = volumeOfSales * 0.12;
                    Console.WriteLine($"{comission:f2}");
                    break;
                case "Varna":
                    comission = volumeOfSales * 0.13;
                    Console.WriteLine($"{comission:f2}");
                    break;
                case "Plovdiv":
                    comission = volumeOfSales * 0.145;
                    Console.WriteLine($"{comission:f2}");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
        else if (volumeOfSales < 0)
            Console.WriteLine("error");

    }
}
