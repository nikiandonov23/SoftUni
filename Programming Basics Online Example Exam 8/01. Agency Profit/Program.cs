using System;

namespace _01._Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfCompany = Console.ReadLine();
            double AdultTickets = double.Parse(Console.ReadLine());
            double KidsTickets = double.Parse(Console.ReadLine());
            double pricePerAdult = double.Parse(Console.ReadLine());
            double taxPrice = double.Parse(Console.ReadLine());

            double pricePerKId = pricePerAdult * 0.30+taxPrice;
            double pricePerAdultt = pricePerAdult + taxPrice;

            double totalTicketsPrice = pricePerAdultt * AdultTickets + pricePerKId * KidsTickets;


            Console.WriteLine($"The profit of your agency from {nameOfCompany} tickets is {totalTicketsPrice*0.20:f2} lv.");

           




        }
    }
}
