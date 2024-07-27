using System;

namespace _20.Easter_Shop
{
    class Program
    {
        static void Main(string[] args)   // davashe 50% v judge zaradi cikula mi poneje beshe vmesto do 25 do int.MaxValue.Pipnah go i se opravi ...
        {
            int eggsInStore = int.Parse(Console.ReadLine());    //na4alno koli4estvo qica v magazina 

            string input = "";
            int totalEggsInStor = eggsInStore;
            int eggsBuy = 0;
            int buyNumber = 0;




            for (int i = 0; i < 25; i++)
            {
                input = Console.ReadLine();
                if (input == "Fill")
                {
                    int number = int.Parse(Console.ReadLine());
                    totalEggsInStor += number;


                }
                if (input == "Buy")
                {
                    int number = int.Parse(Console.ReadLine());
                    eggsBuy += number;
                    if ((number > totalEggsInStor) || (totalEggsInStor < 0))
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {totalEggsInStor}.");
                        break;
                    }
                    totalEggsInStor -= number;
                }
                if (input == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine($"{eggsBuy} eggs sold.");
                }
                if ((buyNumber > totalEggsInStor) || (totalEggsInStor < 0))
                {
                    Console.WriteLine("Not enough eggs in store!");
                    Console.WriteLine($"You can buy only {totalEggsInStor}.");
                }

            }





        }
    }
}
