double grade = double.Parse(Console.ReadLine());
Method();

void Method()
{
    if (grade>=2.0&&grade<=2.99)
    {
        Console.WriteLine("Fail");

    }
    if (grade >= 3.0 && grade <= 3.49)
    {
        Console.WriteLine("Poor");
    }
    if (grade >= 3.5 && grade <= 4.49)
    {
        Console.WriteLine("Good");
    }
    if (grade >= 4.5 && grade <= 5.49)
    {
        Console.WriteLine("Very good");
    }
    if (grade >= 5.5 && grade <= 6.00)
    {
        Console.WriteLine("Excellent");
    }


}
