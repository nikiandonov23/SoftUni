using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int k = 0;

            while (k <= number)
            {
                k = k * 2 + 1;
                if (k > number)
                { break; }
                Console.WriteLine(k);
               
            }

        }
    }
}
