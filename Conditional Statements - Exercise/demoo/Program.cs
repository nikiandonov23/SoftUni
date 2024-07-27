using System;

class hello
{
    static void Main()
    {
        Console.WriteLine("what is your name");
        string name = Console.ReadLine();
        Console.WriteLine("Which year are you born ?");

        
        Double yearOfBirth = Double.Parse(Console.ReadLine());

        Double yourAge = 2023 - yearOfBirth;
        Console.WriteLine($"{name} your age is {yourAge} years");
        Console.WriteLine("I can devide too Press enter and write me two numbers");
        Console.WriteLine("First number");
        Double firstNumber = Double.Parse(Console.ReadLine());
        Console.WriteLine("second number");
        Double secondNumber = Double.Parse(Console.ReadLine());
        Console.WriteLine($"{name} the result of deviding is {firstNumber/secondNumber}");


    }
}
