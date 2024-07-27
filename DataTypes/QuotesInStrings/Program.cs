using System;
    class Program
    {
        static void Main()
        {
        string quotes = "The \"use\" of quotations causes difficulties";
        string noQuotes = @" The ""use"" of quotations causes difficulties";
        Console.WriteLine(quotes);
        Console.WriteLine(noQuotes);
        Console.ReadLine();
        }
    }

