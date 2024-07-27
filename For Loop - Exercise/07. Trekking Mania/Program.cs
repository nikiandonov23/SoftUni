using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());               //broi na grupite
            int Musala = 0;
            int Monblan = 0;
            int Kilimandjaro = 0;
            int k2 = 0;
            int Everest = 0;
            Double totalNumberOfPeople = 0;

            for (int i = 0; i < n; i++)
            {
                int numberPeople = int.Parse(Console.ReadLine());

                if (numberPeople <= 5)
                {
                    Musala += numberPeople;
                    totalNumberOfPeople += numberPeople;
                }
                if ((numberPeople > 5) && (numberPeople <= 12))
                {
                    Monblan += numberPeople;
                    totalNumberOfPeople += numberPeople;
                }
                if ((numberPeople > 12) && (numberPeople <= 25))
                {
                    Kilimandjaro += numberPeople;
                    totalNumberOfPeople += numberPeople;
                }
                if ((numberPeople > 25) && (numberPeople <= 40))
                {
                    k2 += numberPeople;
                    totalNumberOfPeople += numberPeople;
                }
                if (numberPeople >= 41)
                {
                    Everest += numberPeople;
                    totalNumberOfPeople += numberPeople;
                }
                




            }
            Console.WriteLine($"{Musala / totalNumberOfPeople * 100:f2}%");
            Console.WriteLine($"{Monblan / totalNumberOfPeople * 100:f2}%");
            Console.WriteLine($"{Kilimandjaro / totalNumberOfPeople * 100:f2}%");
            Console.WriteLine($"{k2 / totalNumberOfPeople * 100:f2}%");
            Console.WriteLine($"{Everest / totalNumberOfPeople * 100:f2}%");
        }
    }
}
