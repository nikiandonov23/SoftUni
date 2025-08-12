using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            switch (typeProjection)
            {
                case "Premiere":
                    Console.WriteLine($"{(rows * colums * 12):f2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{(rows * colums * 7.50):f2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{(rows * colums * 5.00):f2} leva");
                    break;


            }

        }
    }
}
