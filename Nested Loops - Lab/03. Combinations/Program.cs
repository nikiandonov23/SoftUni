using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int combos = 0;

            for (int n1 = 0; n1 <= number; n1++)
            {
                for (int n2 = 0; n2 <= number; n2++)
                {
                    for (int n3 = 0; n3 <= number; n3++)
                    {
                        if (n1 + n2 + n3 == number)
                        { combos++; }
                    }
                }
            }
            Console.WriteLine(combos);
        }
    }
}
