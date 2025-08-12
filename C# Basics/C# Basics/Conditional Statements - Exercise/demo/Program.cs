using System;

class hello
{
    static void Main()
    {

        int points = int.Parse(Console.ReadLine());
        Double bonus = 0.00;

        if (points <= 100)
        {
            bonus = 5;
        }

        else if ((points > 100 ) && (points<=1000))

        {
            bonus = points * 0.2;
        }

        else
        {
            bonus = points * 0.1;
        }



        if (points % 2 == 0)
        {
            bonus = bonus + 1; //bonus+=1
        }
        else if (points % 10 == 5)
            bonus = bonus + 2;
        Console.WriteLine(bonus);
        Console.WriteLine(points + bonus);
    }
}



