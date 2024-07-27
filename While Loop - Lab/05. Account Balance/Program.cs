using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Double moneySum = 0;
            string input = Console.ReadLine();

            while (input != "NoMoreMoney")                              //text input mi e string , ako toi e razli4en ot NoMoreMoney , preobrazuvame vuv Double i destvame !!!!
            {
                Double moneyFromString = Double.Parse(input);

                if (moneyFromString < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;                                              //S break celiq while cikul prikliu4va, t.e ako imash otricatelno 4islo ne go pulni v!!  Double moneySym=0!!!!
                }
                Console.WriteLine($"Increase: {moneyFromString:f2}");
                moneySum += moneyFromString;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {moneySum:f2}");

        }
    }
}
