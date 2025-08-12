using System;

class hello
{
    static void Main()
    {
        int paintedEggs = int.Parse(Console.ReadLine());

        int redEggs = 0;
        int orangeEggs = 0;
        int blueEgge = 0;
        int greenEggs = 0;
        int maxValue = int.MinValue;
        string maxColour = "";


        for (int i = 1; i <= paintedEggs; i++)
        {
            string colour = Console.ReadLine();
            switch (colour)
            {
                case "red":
                    redEggs += 1;

                    break;
                case "orange":
                    orangeEggs += 1;
                    break;
                case "blue":
                    blueEgge += 1;
                    break;
                case "green":
                    greenEggs += 1;
                    break;
            }
        }
        if (redEggs > maxValue)
        { maxValue = redEggs;
            maxColour = "red";
        }
        if (orangeEggs > maxValue)
        { maxValue = orangeEggs;
            maxColour = "orange";

        }
        if (blueEgge > maxValue)
        { maxValue = blueEgge;
            maxColour = "blue";

        }
        if (greenEggs > maxValue)
        { maxValue = greenEggs;
            maxColour = "green";

        }


        Console.WriteLine($"Red eggs: {redEggs}");
        Console.WriteLine($"Orange eggs: {orangeEggs}");        Console.WriteLine($"Blue eggs: {blueEgge}");        Console.WriteLine($"Green eggs: {greenEggs}");        Console.WriteLine($"Max eggs: {maxValue} -> {maxColour}");
    }
}
