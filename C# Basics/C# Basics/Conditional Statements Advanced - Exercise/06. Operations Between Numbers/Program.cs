using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n1 = Double.Parse(Console.ReadLine());
            Double n2 = Double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            Double result = 0;
            string evenOdd = "";

            switch (operation)
            {
                case "+":
                    result = n1 + n2;
                    if (result % 2 != 0)
                    {
                        evenOdd = "odd";
                    }
                    else
                        evenOdd = "even";
                    Console.WriteLine($"{n1} + {n2} = {result} - {evenOdd}");


                    break;

                case "-":
                    result = n1 - n2;
                    if (result % 2 != 0)
                    {
                        evenOdd = "odd";
                    }
                    else
                    {
                        evenOdd = "even";
                    }
                    Console.WriteLine($"{n1} - {n2} = {result} - {evenOdd}");

                    break;

                case "*":
                    result = n1 * n2;
                    if (result % 2 != 0)
                    {
                        evenOdd = "odd";
                    }
                    else
                    {
                        evenOdd = "even";
                    }
                    Console.WriteLine($"{n1} * {n2} = {result} - {evenOdd}");
                    break;
                case "/":
                    result = n1 / n2;
                    if (n2 > 0)
                    {
                        Console.WriteLine($"{ n1} / { n2} = { result:f2}");
                    }
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
                case "%":
                    result = n1 % n2;
                    if (n2 > 0)
                    {
                        Console.WriteLine($"{n1} % {n2} = {result}");
                    }
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;

            }
        }
    }
}
