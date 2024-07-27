using System;

class hello
{
    static void Main()
    {
        int a = 6;
        switch (a)
        {
            case 5:
            case 6:
               a= a + 1;

                break;
        }
        Console.WriteLine(a);
    }
}