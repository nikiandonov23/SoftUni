using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int nDays = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());

            
            double bonusFromBisquits = 0;

            double eatenFromDogg = 0;
            double eatenFromCatt = 0;


            for (int i = 1; i <= nDays; i++)
            {
                
                double eatenFromDog = double.Parse(Console.ReadLine());               //za vseki den 4ete kolko e qlo ku4eto i kolko koteto
                eatenFromDogg += eatenFromDog;

                double eatenFromCat = double.Parse(Console.ReadLine());
                eatenFromCatt += eatenFromCat;

                double foodEatenForTheDay = eatenFromCat + eatenFromDog;                      //promenlivite foodEatenForTheDay q zabravq na vsqko zavurtane na cikula

                if (i % 3 == 0)
                {

                    bonusFromBisquits += (eatenFromDog + eatenFromCat) * 0.1;


                }


            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(bonusFromBisquits)}gr.");
            Console.WriteLine($"{(eatenFromDogg+eatenFromCatt)/totalFood*100:f2}% of the food has been eaten.");
            Console.WriteLine($"{eatenFromDogg/(eatenFromDogg+eatenFromCatt)*100:f2}% eaten from the dog.");
            Console.WriteLine($"{eatenFromCatt/(eatenFromDogg+eatenFromCatt)*100:f2}% eaten from the cat.");

        }
    }
}
