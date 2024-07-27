using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }

            Console.WriteLine(string.Join(" ",array));
            Console.WriteLine(sum);
        }
    }
}
