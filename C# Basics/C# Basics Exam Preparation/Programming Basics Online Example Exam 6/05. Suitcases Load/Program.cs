using System;

namespace SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double filledCapacity = 0;
            int counterSuitcases = 0;

            string input = Console.ReadLine();

            while (input != "End")
            {
                counterSuitcases++;
                double suitcaseVolume = double.Parse(input);

                if (counterSuitcases % 3 == 0)
                {
                    suitcaseVolume *= 1.10; // Increase volume by 10%
                }

                filledCapacity += suitcaseVolume;

                if (filledCapacity > capacity)
                {
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {counterSuitcases - 1} suitcases loaded.");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Congratulations! All suitcases are loaded!");
            Console.WriteLine($"Statistic: {counterSuitcases} suitcases loaded.");
        }
    }
}