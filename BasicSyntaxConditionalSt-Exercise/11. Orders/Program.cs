using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double priceForAll = 0;

            for (int i = 1; i <= n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double priceForTheCoffe = days * capsulesCount * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${priceForTheCoffe:f2}");
                priceForAll += priceForTheCoffe;



            }
            Console.WriteLine($"Total: ${priceForAll:f2}");

        }
    }
}
