using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {

            // · Ако фигурата е квадрат(square): на следващия ред се чете едно дробно число -дължина на страната му

            //· Ако фигурата е правоъгълник(rectangle): на следващите два реда четат две дробни числа -дължините на страните му

            //· Ако фигурата е кръг(circle): на следващия ред чете едно дробно число - радиусът на кръга

            //· Ако фигурата е триъгълник (triangle) а следващите два реда четат две дробни числа -дължините на страните му

            string figure = Console.ReadLine();


            if (figure == "square")
            {
                Double stranakvadrat = Double.Parse(Console.ReadLine());
                Double area1 = (stranakvadrat * stranakvadrat);
                Console.WriteLine($"{area1:f3}");
            }



            if (figure == "rectangle")
            {
                Double a = Double.Parse(Console.ReadLine());
                Double b = Double.Parse(Console.ReadLine());
                Double area2 = a * b;
                Console.WriteLine($"{area2:f3}");

            }

            if (figure == "circle")
            {
                Double radius = Double.Parse(Console.ReadLine());
                Double area3 = (Math.PI * (radius*radius));
                Console.WriteLine($"{area3:f3}");
            }
            if (figure == "triangle")
            {
                Double strana1 = Double.Parse(Console.ReadLine());
                Double visochina = Double.Parse(Console.ReadLine());
                Double area4 = (strana1 * (visochina/2));
                Console.WriteLine($"{ area4:f3}");
            }
        }
    }
}