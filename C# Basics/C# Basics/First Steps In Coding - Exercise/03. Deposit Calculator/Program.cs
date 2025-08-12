using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Double deposit = Double.Parse(Console.ReadLine());
            Double srok = Double.Parse(Console.ReadLine());
            Double procent = Double.Parse(Console.ReadLine());

            Double total = deposit + srok * ((deposit * procent/100) / 12);

            Console.WriteLine(total);

        }
    }
}
