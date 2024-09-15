// See https://aka.ms/new-console-template for more information

int[] conditions = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int toBeDequeued = conditions[1];
int tobeChecked = conditions[2];


int[] input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Queue<int> numbers = new Queue<int>(input);




for (int i = 0; i < toBeDequeued; i++)
{
    numbers.Dequeue();
}

if (numbers.Count > 0)
{
    if (numbers.Contains(tobeChecked))
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

