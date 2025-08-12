using System;

namespace ExchangeValues
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Variables A and B before the exchange are {0} and {1}",a,b);
            Console.WriteLine("To see the values after the exchange please press ENTER");
            Console.ReadLine();
            a = 10;
            b = 5;
            Console.WriteLine("Variables A and B after the exchange are {0} and {1}", a, b);
            Console.WriteLine("To exit lease press ENTER");
            Console.ReadLine();
        }
    }
}
