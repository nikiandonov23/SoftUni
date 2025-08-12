





int c, a = 0, b = 1, i;

for (i = 0; i < 50; i++)
{
    if (i <= 1)
        c = i;
    else
    {
        c = a + b;
        a = b;
        b = c;
    }

    Console.Write(c + " ");
}