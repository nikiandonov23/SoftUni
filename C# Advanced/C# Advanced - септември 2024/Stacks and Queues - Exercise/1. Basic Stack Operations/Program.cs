// See https://aka.ms/new-console-template for more information

int[] input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int toBePoped = input[1];
int toBeChecked = input[2];


int[] inputt = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Stack<int>numbers=new Stack<int>(inputt);


for (int i = 0; i < toBePoped; i++)
{

    if (numbers.Count>0)
    {
        numbers.Pop();
    }
    
}

if (numbers.Count>0)
{
    if (numbers.Contains(toBeChecked))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine(numbers.Min());
    }
}

else
{
    Console.WriteLine("0");
}