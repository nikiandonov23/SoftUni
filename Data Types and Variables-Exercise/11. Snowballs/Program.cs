using System;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double maxValue = 0;
                

            double finalSnow = 0;
            double finalTime = 0;
            double finaQuality = 0;



            for (int i = 1; i <= n; i++)
            {
                double snow = double.Parse(Console.ReadLine());              //10
                double time = double.Parse(Console.ReadLine());              //2
                double quality = double.Parse(Console.ReadLine());           //3

                double value = Math.Pow(snow / time, quality);               //125 demek 5 na 3-ta stepen

                if (value > maxValue)
                {
                    maxValue = value;
                    finaQuality = quality;
                    finalSnow = snow;
                    finalTime = time;
                    
                }
              
            }
            Console.WriteLine($"{finalSnow} : {finalTime} = {maxValue} ({finaQuality})");
        }
    }
}
