using System;

namespace niki
{
    class Program
    {
        static void Main(string[] args)                 // Между 10 (вкл.) и 15 (вкл.) човека -> 15 % отстъпка от куверта за един човек
                                                        // Между 15 и 20 (вкл.) човека -> 20 % отстъпка от куверта за един човек
                                                        // Над 20 човека -> 25 % отстъпка от куверта за един човек
        {
            int numberGuest = int.Parse(Console.ReadLine());
            Double pricePerPerson = Double.Parse(Console.ReadLine());
            Double budget = Double.Parse(Console.ReadLine());

            Double priceForAllAfter = 0;


            Double cakePrice = budget * 0.10;


            if ((numberGuest >= 10) && (numberGuest <= 15))
            {
                priceForAllAfter += pricePerPerson * 0.85 * numberGuest;
            }
            if ((numberGuest > 15) && (numberGuest <= 20))
            {
                priceForAllAfter += pricePerPerson * 0.80 * numberGuest;

            }
            if (numberGuest > 20)
            {
                priceForAllAfter += pricePerPerson * 0.75 * numberGuest;

            }
            if (numberGuest < 10)
            {
                priceForAllAfter += pricePerPerson * numberGuest;
            }
            Double partySum = priceForAllAfter + cakePrice;

            
            if (budget >= partySum)
            { Console.WriteLine($"It is party time! {budget - partySum:f2} leva left."); }
            if (budget < partySum)
            {
                Console.WriteLine($"No party! {partySum - budget:f2} leva needed.");
            }


        }
    }
}
