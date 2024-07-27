using System;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxValue = 0;


            int finalSnow = 0;
            int finalTime = 0;
            int finaQuality = 0;



            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());              //10
                int time = int.Parse(Console.ReadLine());              //2
                int quality = int.Parse(Console.ReadLine());           //3

                int value = snow / time;               //125 demek 5 na 3-ta stepen

                int result = 1;

                for (int k = 0; k < quality; k++)
                {
                     result*=value;
                }

                if (result >= maxValue)
                {
                    maxValue = result;
                    finaQuality = quality;
                    finalSnow = snow;
                    finalTime = time;

                }

            }
            Console.WriteLine($"{finalSnow} : {finalTime} = {maxValue} ({finaQuality})");
        }
    }
}
