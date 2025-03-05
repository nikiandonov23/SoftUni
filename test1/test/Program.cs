// See https://aka.ms/new-console-template for more information

using test.Contracts;
using test.Models;

Console.WriteLine($"Hello dear player...");
Console.WriteLine($"Great me saying the word HELLO");

string keyword=Console.ReadLine();
if (keyword!="HELLO")
{
    Console.WriteLine($"YOU DID NOT GREAT YOUR GOD PROPERLY");
    Console.WriteLine($"NOW YOU DIE...");
    string gameover = "GAME OVER";
    for (int i = 0; i < gameover.Length; i++)
    {
        for (int j = 0; j < 100; j++)
        {
            Console.Write(gameover[i]);
        }

        Console.WriteLine();
    }
}
else
{
    Console.WriteLine($"Now when you say it right...");
    
    Console.WriteLine($"It is time...");
    Console.WriteLine();
    Console.WriteLine($"CHOOSE YOUR LEGACY");
    Console.WriteLine();
    Console.WriteLine($"1. WAREWOLF");
    Console.WriteLine($"2. VAMPIRE");
    Console.WriteLine($"press 1 or 2 ....");
    string choose = Console.ReadLine();
    IHero hero = null;
    if (choose=="1")
    {
        hero = new Warewolf();
    }

    if (choose=="2")
    {
        hero = new Vampire();
    }

    Console.WriteLine($"Congrats..Now when u have chosen lets see what u EAT and what is your Specialty");

    hero.eat();
    hero.Specialty();

    Console.WriteLine($"your hero can also calculate some stuff...Depending on what u chose VAMPIRE or WAREWOLF");
    Console.WriteLine($"vampires can plus and minus");
    Console.WriteLine($"warewolfs can multiply and devide");
    Console.WriteLine($"lets do some math");
    Console.WriteLine();
    Console.WriteLine($"Give me your first number");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"give me you sign");
    char sign = char.Parse(Console.ReadLine());
    Console.WriteLine($"Give me your second number");
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine($"{hero.Math(n1, sign, n2)}");



}