// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Runtime.InteropServices;

int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Func<int[], int[]> add = x => x.Select(x => x + 1).ToArray();
Func<int[], int[]> subtract = x => x.Select(x => x - 1).ToArray();
Func<int[], int[]> multiply = x => x.Select(x => x * 2).ToArray();
Action<int[]> action = x => Console.WriteLine(string.Join(" ", x));

string command = "";
while ((command = Console.ReadLine()) != "end")
{
    switch (command)
    {
        case "add":
           input= add(input);
            break;


        case "subtract":
            input = subtract(input);
            break;


        case "multiply":
            input = multiply(input);
            break;


        case "print":
             action(input);
            break;
    }
}