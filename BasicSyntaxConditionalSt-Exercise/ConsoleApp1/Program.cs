using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double priceForPerson = 0;

            if (typeGroup == "Students")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        priceForPerson = 8.45;
                        break;
                    case "Saturday":
                        priceForPerson = 9.80;
                        break;
                    case "Sunday":
                        priceForPerson = 10.46;
                        break;
                }
            }
            else if (typeGroup == "Business")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        priceForPerson = 10.90;
                        break;
                    case "Saturday":
                        priceForPerson = 15.60;
                        break;
                    case "Sunday":
                        priceForPerson = 16;
                        break;
                }
            }
            else if (typeGroup == "Regular")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        priceForPerson = 15;
                        break;
                    case "Saturday":
                        priceForPerson = 20;
                        break;
                    case "Sunday":
                        priceForPerson = 22.50;
                        break;
                }
            }

            double totalPrice = priceForPerson * numberPeople;
            double finalPrice = totalPrice;

            if ((typeGroup== "Students")&&(numberPeople>=30))
            {
                finalPrice = 0;
                finalPrice = totalPrice * 0.85;
            }
            if ((typeGroup == "Business") && (numberPeople >= 100))
            {
                finalPrice = 0;
                finalPrice = priceForPerson * (numberPeople - 10);
            }
            if ((typeGroup == "Regular") && (numberPeople >= 10)&&(numberPeople<=20))
            {
                finalPrice = 0;
                finalPrice = totalPrice * 0.95;
            }
            Console.WriteLine($"Total price: {finalPrice:f2}");
        }
    }
}
