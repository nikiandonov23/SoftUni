using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1 = decimal.Parse(Console.ReadLine());
            decimal n2 = decimal.Parse(Console.ReadLine());

            decimal n3 = n1 - n2;
            decimal absNum = Math.Abs(n3);
            decimal constant = 0.000001m;

            if (absNum<constant)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            

        }
    }
}
