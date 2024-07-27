// See https://aka.ms/new-console-template for more information






void method(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}



int n = int.Parse(Console.ReadLine());   //3
method(n);
