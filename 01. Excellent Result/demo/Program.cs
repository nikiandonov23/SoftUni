using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {


            string figure = Console.ReadLine();
            Double area = 0;





            if (figure == "square")
            {                                                                 ////PROMENLIVITE SI GI POMNI SAMO PO EDIN CIKUL.ZATOVA MOJE DA SE IZPOLZVAT EDNI I SASHTI IMENA {}


                Double a = Double.Parse(Console.ReadLine());
                area = (a * a);
                Console.WriteLine($"{ area:f3}");
            }

            else if (figure == "rectangle")
            {                                                                  ////PROMENLIVITE SI GI POMNI SAMO PO EDIN CIKUL.ZATOVA MOJE DA SE IZPOLZVAT EDNI I SASHTI IMENA {}
                Double a = Double.Parse(Console.ReadLine());
                Double b = Double.Parse(Console.ReadLine());
                area = (a * b);
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "circle")
            {                                                                  ////PROMENLIVITE SI GI POMNI SAMO PO EDIN CIKUL.ZATOVA MOJE DA SE IZPOLZVAT EDNI I SASHTI IMENA {}
                Double r = Double.Parse(Console.ReadLine());
                area = (Math.PI * (r * r));
                Console.WriteLine($"{area:f3}");

            }
            else if (figure == "triangle")
            {                                                                  ////PROMENLIVITE SI GI POMNI SAMO PO EDIN CIKUL.ZATOVA MOJE DA SE IZPOLZVAT EDNI I SASHTI IMENA {}
                Double a = Double.Parse(Console.ReadLine());
                Double b = Double.Parse(Console.ReadLine());
                area = (a * (b / 2));
                Console.WriteLine($"{area:f3}");
            }



        }
    }
}