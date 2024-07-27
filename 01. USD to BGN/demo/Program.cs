using System;

class hello
{
    static void Main()
    {
        Double sqmeters = Double.Parse(Console.ReadLine())*7.61;
        Double discount = sqmeters * 18 / 100;
        Console.WriteLine($"The final price is: { sqmeters - discount } lv.");
        Console.WriteLine($"The discount is: {discount} lv.");

        
    }
}
