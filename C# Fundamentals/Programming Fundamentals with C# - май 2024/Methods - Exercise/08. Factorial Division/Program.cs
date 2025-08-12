// See https://aka.ms/new-console-template for more information


int num1 = Math.Abs(int.Parse(Console.ReadLine()));
int num2 = Math.Abs(int.Parse(Console.ReadLine()));


Console.WriteLine($"{(methodFactorial(num1)) / (methodFactorial(num2)):f2}");


double methodFactorial(int number)
{
    double factorial = 1;

    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }

    return factorial;
}

