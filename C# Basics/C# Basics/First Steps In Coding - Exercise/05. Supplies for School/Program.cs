using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            Double himikal = Double.Parse(Console.ReadLine());
            himikal = himikal * 5.80;
            Double marker = Double.Parse(Console.ReadLine());
            marker = marker * 7.20;
            Double preparat = Double.Parse(Console.ReadLine());
            preparat = preparat*1.20;

            Double procent = Double.Parse(Console.ReadLine());

            Double sum = himikal + marker + preparat;

            Double discount = sum * procent/100;

            Double total = sum - discount;

            Console.WriteLine(total);
        }
    }
}
