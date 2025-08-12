using System;

namespace demooo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());   //945

            int numberCopy = number;
            int factoreilSum = 0;

            while (numberCopy>0)
            {
                int digit = numberCopy % 10;
                numberCopy /= 10;

                int factoriel = 1;

                for (int i = 1; i <= digit; i++)
                {
                    factoriel *= i;
                }
                factoreilSum += factoriel;
               
            }
            if (factoreilSum==number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            

        }
    }
}
