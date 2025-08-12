using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Double pileshko =Double.Parse(Console.ReadLine())*10.35;
            Double riba = Double.Parse(Console.ReadLine())* 12.40;
            Double vegetarian = Double.Parse(Console.ReadLine())* 8.15;

            Double desert = (pileshko + riba + vegetarian) * 20 / 100;

            Double obshto = pileshko + riba + vegetarian + desert + 2.50;
            Console.WriteLine(obshto);

               
        }
    }
}
