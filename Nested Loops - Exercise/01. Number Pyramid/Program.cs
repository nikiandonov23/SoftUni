using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;

            bool isBigger = false;

            for (int rows = 1; rows <= n; rows++)
            {

                
                for (int colum  = 1; colum <= rows; colum++)
                {
                    
                    Console.Write($"{counter} ");
                    counter++;

                    if (counter > n)
                    { break; }
                    isBigger = true;
                }
                Console.WriteLine();
                if (counter>n)
                { break; }

            }

        }
    }
}
