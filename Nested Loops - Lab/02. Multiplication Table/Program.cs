using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int firstMultiplier = 1; firstMultiplier <= 10; firstMultiplier++)
            {
                for (int secondMultiplier = 1; secondMultiplier <= 10; secondMultiplier++)
                {
                    Console.WriteLine($"{firstMultiplier} * {secondMultiplier} = {firstMultiplier*secondMultiplier}");
                }
            }
        }
    }
}
