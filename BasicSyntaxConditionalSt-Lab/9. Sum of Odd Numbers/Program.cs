using System;

namespace _9._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if ((i%2!=0)&&(counter<n))
                {
                    counter += 1;
                    sum += i;
                    Console.WriteLine(i);
                    
                }

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
