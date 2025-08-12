using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                                      //GODINI NA LILI
            Double machinePrice = Double.Parse(Console.ReadLine());                     //CENA NA PERALNQTA
            int toyPrice = int.Parse(Console.ReadLine());                               //CENA NA EDNA IGRA4KA

            Double moneyOfBirthdays = 0;
            int numberOfToys = 0;
            Double sumToyPrice = 0;
            int addMoney = 10;


            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    moneyOfBirthdays += addMoney;
                    addMoney += 10;
                    moneyOfBirthdays -= 1;

                }

            }
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    numberOfToys += 1;
                    sumToyPrice = numberOfToys * toyPrice;
                }
            }
            if ((sumToyPrice + moneyOfBirthdays) >= (machinePrice))
            {
                Console.WriteLine($"Yes! {(sumToyPrice + moneyOfBirthdays) - (machinePrice):f2}");
            }
            if ((sumToyPrice + moneyOfBirthdays) < (machinePrice))
            {
                Console.WriteLine($"No! {Math.Abs((sumToyPrice + moneyOfBirthdays) - (machinePrice)):f2}");

            }
        }
    }
}
