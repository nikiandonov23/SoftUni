// See https://aka.ms/new-console-template for more information



int n = int.Parse(Console.ReadLine());
Console.WriteLine(methodTribonacci(n));



string methodTribonacci(int inputNum)
{
    int numbers, a = 0, b = 1, c = 1, d, i;
    string result = "";
    for (i = 0; i < n; i++)
    {
        if (i <= 1)
            d = i;
        else
        {
            d = a + b + c;
            a = b;
            b = c;
            c = d;
        }

        result += c + " ";
    }


    return result;
}

