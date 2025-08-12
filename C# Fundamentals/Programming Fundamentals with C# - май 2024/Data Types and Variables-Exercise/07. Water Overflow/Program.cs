using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalamount = 255;

            int litersPoured = 0;

            for (int i = 1; i <= n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input <= totalamount)
                {
                    totalamount -= input;
                    litersPoured += input;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine(litersPoured);
        }
    }
}
