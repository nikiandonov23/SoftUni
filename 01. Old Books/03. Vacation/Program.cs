using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            Double tripMoney = Double.Parse(Console.ReadLine());
            Double startMoney = Double.Parse(Console.ReadLine());

            int spendDays = 0;
            int days = 0;

            Double spendMoney = 0;
            Double savedMoney = 0;





            while (true)
            {
                if (spendDays >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{days}");
                    break;
                }
                if (startMoney >= tripMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;

                }
                string command = Console.ReadLine();
                Double spendOrSave = Double.Parse(Console.ReadLine());

                if (command == "spend")
                {
                    startMoney -= spendOrSave;
                    days++;
                    spendDays++;
                    if (startMoney <= 0)
                    {
                        startMoney = 0;
                    }
                }
                if (command == "save")
                {
                    startMoney += spendOrSave;
                    days++;
                }
            }



        }
    }
}
