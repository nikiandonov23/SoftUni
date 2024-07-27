using System;

class hello
{
    static void Main()
    {
        Console.WriteLine("Enter your first number to compare");
        double input1 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Enter your second number to compare");
        double input2 = Double.Parse(Console.ReadLine());
        double eps = 0.01;
        if (Math.Abs(input1 - input2) > eps)
        {
            Console.WriteLine("False");
            Console.ReadLine();
        }
        else if (Math.Abs(input1 - input2) < eps)
        {
            Console.WriteLine(true);
            Console.ReadLine();
        }
        else
            {
            Console.WriteLine("False");
            Console.ReadLine();


        }


    }
}


