using System;
using System.Numerics;
namespace _11.Snowballs_with_Using.Sysyrm.Numerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger maxValue = 0;


            double finalSnow = 0;
            double finalTime = 0;
            double finaQuality = 0;



            for (int i = 1; i <= n; i++)
            {
                int snow = int.Parse(Console.ReadLine());              //10
                int time = int.Parse(Console.ReadLine());              //2
                int quality = int.Parse(Console.ReadLine());           //3

                BigInteger value = BigInteger.Pow(snow / time, quality);               //125 demek 5 na 3-ta stepen

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
