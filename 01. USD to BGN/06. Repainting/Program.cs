using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a = Double.Parse(Console.ReadLine());
            Double nailon = 1.50 * (a + 2);

            Double b = Double.Parse(Console.ReadLine());
            Double boq = 14.50 * (b + b * 10 / 100);


            Double c = Double.Parse(Console.ReadLine());
            Double razreditel = 5.00 * c;

            Double chasove = Double.Parse(Console.ReadLine());

            Double torbichki = 0.40;

            Double sumamateriali = nailon + boq + razreditel + torbichki; ///obshto materialite struvat tolkova



            Double sumatrud = (sumamateriali * 30 / 100) * chasove; //// Obahstata suma za rabotata na maistorite

            Double obshto = sumatrud + sumamateriali;
            Console.WriteLine(obshto);

        }
    }
}
