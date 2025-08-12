// See https://aka.ms/new-console-template for more information



string input=Console.ReadLine();
method();

void method()
{
    int lenght = input.Length;

    if (lenght % 2 != 0)
    {
        int middle = lenght / 2;
        Console.WriteLine(input[middle]);
    }
    else
    {
        int middle = lenght / 2;
        Console.Write((input[middle - 1]).ToString() + (input[middle]).ToString());
    }
}





