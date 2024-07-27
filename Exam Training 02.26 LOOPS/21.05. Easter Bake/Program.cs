using System;

namespace _21._05._Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakeNumber = int.Parse(Console.ReadLine());

            Double totalSugar = 0;
            Double totalFlour = 0;

            int maxUsedSugar = int.MinValue;
            int maxUsedFlour = int.MinValue;

            for (int i = 1; i <= bakeNumber; i++)
            {
                int usedSugar = int.Parse(Console.ReadLine());
                totalSugar += usedSugar;
                if (usedSugar > maxUsedSugar)
                { maxUsedSugar = usedSugar; }

                int usedFlour = int.Parse(Console.ReadLine());
                totalFlour += usedFlour;
                if (usedFlour > maxUsedFlour)
                { maxUsedFlour = usedFlour; }

            }
            Double packsSugar = (Math.Ceiling(totalSugar / 950));
            Double packsFlour = (Math.Ceiling(totalFlour / 750));
            Console.WriteLine($"Sugar: {packsSugar}");
            Console.WriteLine($"Flour: {packsFlour}");            Console.WriteLine($"Max used flour is {maxUsedFlour} grams, max used sugar is {maxUsedSugar} grams.");
        }
    }
}
