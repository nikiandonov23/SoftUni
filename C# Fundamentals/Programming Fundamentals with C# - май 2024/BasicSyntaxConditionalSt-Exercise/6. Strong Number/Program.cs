using System;

namespace _6._Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNumber = Console.ReadLine();
            int numberLenght = stringNumber.Length;

            int number = int.Parse(stringNumber);
            int numberCopy = number;

            int factorielSum = 0;

            while (numberCopy>0)
            {
                int digit = numberCopy % 10;
                numberCopy /= 10;
                int factoriel = 1;

                for (int i = 1; i <= digit; i++)
                {
                     factoriel*= i;
                }
                factorielSum += factoriel;
                
            }
            if (factorielSum==number)
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
