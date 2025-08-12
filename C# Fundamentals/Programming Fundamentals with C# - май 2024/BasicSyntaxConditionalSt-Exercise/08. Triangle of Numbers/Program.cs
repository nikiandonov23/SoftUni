using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());   //3

            for (int i = 1; i <= n; i++) //vurti cikul ot 1 do 3
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
