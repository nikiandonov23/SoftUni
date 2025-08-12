// See https://aka.ms/new-console-template for more information


List<string> input = Console.ReadLine()
    .Split(" ")
    .ToList();

Queue<string> names = new Queue<string>(input);    // Alva James William


int n = int.Parse(Console.ReadLine());

while (names.Count>1)
{
    for (int i = 0; i < n-1; i++)
    {
        names.Enqueue(names.Dequeue());

    }

    Console.WriteLine($"Removed {names.Dequeue()}");
}

Console.WriteLine($"Last is {names.Dequeue()}");

