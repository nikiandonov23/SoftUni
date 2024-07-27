int n = int.Parse(Console.ReadLine());
piramyd();
void piramyd()
{
    for (int i = 1; i <= n; i++)   //vurti nagore nadolu
    {

        for (int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }

        Console.WriteLine();
    }

    for (int i = n; i >= 1; i--)
    {
        for (int j = 1; j <= i - 1; j++)
        {
            Console.Write(j + " ");
        }

        Console.WriteLine();
    }
}

