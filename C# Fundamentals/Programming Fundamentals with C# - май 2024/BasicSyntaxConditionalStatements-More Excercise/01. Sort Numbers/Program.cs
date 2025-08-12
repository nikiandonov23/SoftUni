using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int mid = 0;
            int max = int.MinValue;
            int min = int.MaxValue;


            if (a > b && a > c)
            {
                max = a;
            }
            if (b > a && b > c)
            {
                max = b;
            }
            if (c > a && c > b)
            {
                max = c;
            }



            if (a < b && a < c)
            {
                min = a;
            }
            if (b < a && b < c)
            {
                min = b;
            }
            if (c < a && c < b)
            {
                min = c;
            }


            if ((a != min) && (a != max))
            {
                mid = a;
            }
            if ((b != min) && (b != max))
            {
                mid = b;
            }
            if ((c != min) && (c != max))
            {
                mid = c;
            }

            if (max == int.MinValue && min != int.MaxValue)
            {
                max = mid;
            }
            if (max != int.MinValue && min == int.MaxValue)
            {
                min = mid;
            }

            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);
        }
    }
}
