using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a = Double.Parse(Console.ReadLine());
            Double b = Double.Parse(Console.ReadLine());
            Double c = Double.Parse(Console.ReadLine());
            Double procentzaetost = Double.Parse(Console.ReadLine());
            procentzaetost = procentzaetost / 100;

            Double Vsm = a * b * c;
            Double Vlt = Vsm * 0.001;



            Double svobodenobem = Vlt - (Vlt * procentzaetost);

            Console.WriteLine(svobodenobem);

        }
    }
}
