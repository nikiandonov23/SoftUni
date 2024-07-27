using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());

            double filledCapacity = 0;
            double counterBriefcase = 0;

            string input = Console.ReadLine(); //obem na kufara v string

            while (input != "End")
            {
                counterBriefcase++;

                double briefcaseVolume = double.Parse(input);

                if ((counterBriefcase % 3 == 0)&&(counterBriefcase!=0))
                {
                    briefcaseVolume *= 1.10;
                }

                filledCapacity += briefcaseVolume;

                if (capacity - filledCapacity < 0) // Adjusted condition
                {
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {counterBriefcase-1} suitcases loaded."); // Corrected counter
                    break;
                }
                

                input = Console.ReadLine();
            }

            double leftEmpty = capacity - filledCapacity;

            Console.WriteLine("Congratulations! All suitcases are loaded!");
            Console.WriteLine($"Statistic: {counterBriefcase} suitcases loaded."); // Corrected counter
        }
    }
}