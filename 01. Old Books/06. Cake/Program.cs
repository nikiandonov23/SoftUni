using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int caceSize = lenght * width;
            int caceSizeLeft = caceSize;

           

            string input = "";
            while (input!="STOP")
            {
                input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{caceSizeLeft} pieces are left.");
                    break;
                }


                int inputAsNumber = int.Parse(input);

                caceSizeLeft -= inputAsNumber;

                if (caceSizeLeft <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(caceSizeLeft)} pieces more.");
                    break;
                }



                

            }
            
        }
    }
}
