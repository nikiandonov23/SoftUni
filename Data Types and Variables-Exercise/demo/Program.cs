using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double biggestKeg = 0;

            string biggest = "";

            for (int i = 1; i <=n; i++)                   
            {
                string kegName = Console.ReadLine();

                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double kegArea = Math.PI * (radius * radius) * height;

                if (biggestKeg<kegArea)
                {
                    biggestKeg = kegArea;
                    biggest = kegName;
                }
            }
            Console.WriteLine(biggest);


        }
    }
}
