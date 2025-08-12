using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorNumber = int.Parse(Console.ReadLine());
            int flatNumber = int.Parse(Console.ReadLine());

            for (int i = floorNumber; i >= 1; i--)         //vurti etajite
            {
                for (int j = 0; j < flatNumber; j++)     //vurti flatovete na etaj
                {
                    if (i % floorNumber == 0)
                    {
                        Console.Write($"L{i}{j} ");
                    }

                    if ((i % 2 == 0) && (i % floorNumber != 0))
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    if ((i % 2 != 0) && (i % floorNumber != 0))
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
