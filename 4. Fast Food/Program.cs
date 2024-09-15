// See https://aka.ms/new-console-template for more information


int totalFood = int.Parse(Console.ReadLine());

int[] input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Queue<int>orders=new Queue<int>(input);
Console.WriteLine(orders.Max());

while (orders.Count>0)
{
    if (totalFood>=orders.Peek())
    {
        int currentOrder=orders.Dequeue();
        totalFood -= currentOrder;
    }
    else if (totalFood<orders.Peek())
    {
        Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
        break;
    }
}

if (orders.Count == 0)
{
    Console.WriteLine("Orders complete");
}
