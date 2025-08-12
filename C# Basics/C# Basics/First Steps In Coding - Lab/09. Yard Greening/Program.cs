using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            Double plosht = Double.Parse(Console.ReadLine());
            Double cenakvadrat = 7.61;
            Double total = plosht * cenakvadrat;

            Double discount = total * 18 / 100;

            Console.WriteLine($"The final price is: {total-discount} lv.");

            Console.WriteLine($"The discount is: {discount} lv.");


        }
    }
}
