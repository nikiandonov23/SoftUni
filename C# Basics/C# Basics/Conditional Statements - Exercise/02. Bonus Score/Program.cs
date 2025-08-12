using System;

class hello
{
    static void Main()
    {
        //· Ако числото е до 100 включително, бонус точките са 5.
        //· Ако числото е по-голямо от 100, бонус точките са 20 % от числото.
        //· Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.

        //o За четно число  + 1 т.
        //o За число, което завършва на 5  + 2 т.


        Double number = Double.Parse(Console.ReadLine());
        Double bonus = 0.00;

        if (number <= 100)
        { bonus = 5; }

        else if (number > 1000)
        { bonus = (number * 0.10); }

        else if (number > 100)
        { bonus = (number * 0.20); }

        










        if (number % 2 == 0)
        { bonus = bonus + 1; }
        else if (number % 10 == 5)
        { bonus = bonus + 2; }


        Console.WriteLine(bonus);
        Console.WriteLine(number + bonus);


    }
}



