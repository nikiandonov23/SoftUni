﻿
string beverage=Console.ReadLine();
double n=double.Parse(Console.ReadLine());
method();

void method()
{
    double price = 0;
    switch (beverage)
    {
        case "coffee":
            price = 1.50;
            break;

        case "water":
            price = 1.00;

            break;
        case "coke":
            price = 1.40;

            break;
        case "snacks":
            price = 2.00;

            break;
           
    }
    Console.WriteLine($"{price * n:f2}");

}