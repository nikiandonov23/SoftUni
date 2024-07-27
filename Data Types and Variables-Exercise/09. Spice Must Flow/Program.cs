using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yeld = int.Parse(Console.ReadLine());
            int counter = 0;

            int amount = 0;

            while (yeld > 0)
            {
                if (yeld < 100)
                {
                    if (amount < 26)
                    {
                        break;
                    }
                    amount -= 26;
                    break;
                }


                amount += yeld - 26;
                yeld -= 10;


                counter++;
            }
            Console.WriteLine(counter);
            Console.WriteLine(amount);
        }
    }
}
