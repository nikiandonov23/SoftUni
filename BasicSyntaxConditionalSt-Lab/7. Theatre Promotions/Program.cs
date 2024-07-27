using System;

namespace _7._Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

            switch (typeOfDay)
            {
                case "Weekday":
                    if ((age>=0)&&(age<=18))
                    {
                        ticketPrice = 12;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else if ((age > 18) && (age <= 64))
                    {
                        ticketPrice = 18;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else if ((age > 64) && (age <= 122))
                    {
                        ticketPrice = 12;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else
                    {
                        Console.WriteLine($"Error!");
                    }

                    break;



                case "Weekend":
                    if ((age >= 0) && (age <= 18))
                    {
                        ticketPrice = 15;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else if ((age > 18) && (age <= 64))
                    {
                        ticketPrice = 20;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else if ((age > 64) && (age <= 122))
                    {
                        ticketPrice = 15;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else
                    {
                        Console.WriteLine($"Error!");
                    }
                    break;



                case "Holiday":
                    if ((age >= 0) && (age <= 18))
                    {
                        ticketPrice = 5;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else if ((age > 18) && (age <= 64))
                    {
                        ticketPrice = 12;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else if ((age > 64) && (age <= 122))
                    {
                        ticketPrice = 10;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else
                    {
                        Console.WriteLine($"Error!");
                    }

                    break;
            }
        }
    }
}
