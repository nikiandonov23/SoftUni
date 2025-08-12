using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cacke = rent * 0.20;
            double drinks = cacke * 0.55;
            double animator = rent / 3;

            double totalMoney = rent + cacke + drinks + animator;
            Console.WriteLine(totalMoney);

        }
    }
}
