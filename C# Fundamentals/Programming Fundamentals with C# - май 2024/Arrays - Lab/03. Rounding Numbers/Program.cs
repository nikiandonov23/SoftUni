using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());

            string[] arrayy = input.Split();            //imamme masiv s razdeleniqta

            for (int i = 0; i < arrayy.Length; i++)     //vurti desetichnite nomera v masiva
            {
                double number = double.Parse(arrayy[i]);
                int roundedNumber =(int) Math.Round(number, 0, MidpointRounding.AwayFromZero);    //round away from 0 style

                Console.WriteLine($"{number} => {roundedNumber}");
            }



        }
    }
}
