using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double totalLiters = 0;
            double totalDegreeForLiters = 0;

            for (int i = 1; i <= days; i++)
            {
                double rakiaAmount = double.Parse(Console.ReadLine());
                totalLiters += rakiaAmount;

                double gradusRakia = double.Parse(Console.ReadLine());
                totalDegreeForLiters += gradusRakia * rakiaAmount;


            }
            Console.WriteLine($"Liter: {totalLiters:f2}");
            double finalDegrees= totalDegreeForLiters / totalLiters;
            Console.WriteLine($"Degrees: {finalDegrees:f2}");
            if (finalDegrees<38)
            {
                Console.WriteLine($"Not good, you should baking!");
            }
            if ((finalDegrees>=38)&&(finalDegrees<=42))
            {
                Console.WriteLine("Super!");
            }
            if (finalDegrees>42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
