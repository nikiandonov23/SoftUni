using System;

namespace _02._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Double radiani = Double.Parse(Console.ReadLine());
            Double gradus = radiani * 180 / Math.PI;
            Console.WriteLine(gradus);

        }
    }
}
