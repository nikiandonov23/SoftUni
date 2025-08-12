using System;

class hello
{
    static void Main()
    {
        int temperature = int.Parse(Console.ReadLine());
        string timeOfTheDay = Console.ReadLine();

        string outfit = "";
        string shoes = "";
        if (timeOfTheDay == "Morning")
        {
            if ((temperature >= 10) && (temperature <= 18))
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";



            }

            else if ((temperature > 18) && (temperature <= 24))

            {
                outfit = "Shirt";
                shoes = "Moccasins";


            }
            else if (temperature >= 25)
            {
                outfit = "T-Shirt";
                shoes = "Sandals";

            }
            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");



        }
        else if (timeOfTheDay == "Afternoon")
        {
            if ((temperature >= 10) && (temperature <= 18))
            {
                outfit = "Shirt";
                shoes = "Moccasins";



            }

            else if ((temperature > 18) && (temperature <= 24))

            {
                outfit = "T-Shirt";
                shoes = "Sandals";


            }
            else if (temperature >= 25)
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";

            }
            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");



        }

        else if (timeOfTheDay == "Evening")
        {
            if ((temperature >= 10) && (temperature <= 18))
            {
                outfit = "Shirt";
                shoes = "Moccasins";



            }

            else if ((temperature > 18) && (temperature <= 24))

            {
                outfit = "Shirt";
                shoes = "Moccasins";


            }
            else if (temperature >= 25)
            {
                outfit = "Shirt";
                shoes = "Moccasins";

            }
            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");



        }


    }
}
