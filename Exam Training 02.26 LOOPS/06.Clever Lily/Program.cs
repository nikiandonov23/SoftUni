using System;

namespace _06.Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            Double washingMachinePrice = Double.Parse(Console.ReadLine());
            Double toyPrice = Double.Parse(Console.ReadLine());

            Double moneyOfBirthdays = 0;
            Double totalMoneyOfBirthdays = 0;

            int toyBirthdays = 0;
            Double toySum = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyOfBirthdays += 10;
                    totalMoneyOfBirthdays += moneyOfBirthdays;
                    totalMoneyOfBirthdays -= 1;

                }

            }
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toyBirthdays += 1;
                    toySum = toyBirthdays * toyPrice;
                }
            }
            Double totalSum = toySum + totalMoneyOfBirthdays;
            if (washingMachinePrice <= totalSum)
            { Console.WriteLine($"Yes! {totalSum - washingMachinePrice:f2}"); }
            else if (washingMachinePrice > totalSum)
            { Console.WriteLine($"No! {washingMachinePrice-totalSum:f2}"); }

        }
    }
}
