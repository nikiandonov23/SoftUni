using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string input = "";

            int flatSIze = width * lenght * height;

            int flatSizeAfterBoxes = flatSIze;

            while (input!= "Done")
            {
                input = Console.ReadLine();
                if (input == "Done")
                {
                    Console.WriteLine($"{flatSizeAfterBoxes} Cubic meters left.");
                    break;
                }
                int inputAsNumber = int.Parse(input);
                flatSizeAfterBoxes -= inputAsNumber;

                if (flatSizeAfterBoxes <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(flatSizeAfterBoxes)} Cubic meters more.");
                    break;
                }
                
            }
            



        }
    }
}
