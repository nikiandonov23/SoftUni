using System;

namespace _07.Back_in__the_Future
{
    class Program
    {
        static void Main(string[] args)
        {
            Double nasledstvo = Double.Parse(Console.ReadLine());
            int godina = int.Parse(Console.ReadLine());

            Double moneySpent = 0;

            for (int i = 1800; i <= godina; i++)
            {
                if (i % 2 == 0)
                {
                    moneySpent += 12000;
                }
                
            }
            for (int i = 1800; i <= godina; i++)
            {
                if (i % 2 != 0)
                {
                    moneySpent += 12000 + 50 * (i-1800+18);
                }
            }
            if (moneySpent <= nasledstvo)
            { Console.WriteLine($"Yes! He will live a carefree life and will have {nasledstvo - moneySpent:f2} dollars left."); }
            else
            { Console.WriteLine($"He will need {moneySpent-nasledstvo:f2} dollars to survive."); }
        }
    }
}
