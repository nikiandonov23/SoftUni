using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number%2==0)
            {
                Console.WriteLine($"The number is: {Math.Abs(number)}");
               

            }

            while (number % 2 != 0)
            {
                Console.WriteLine($"Please write an even number.");
                number = int.Parse(Console.ReadLine());
                if (number%2==0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
                switch (number)
                {
                    case 1:
                        break;              
                }
            }                           


        }
    }
}
