// See https://aka.ms/new-console-template for more information

int[] input = Console.ReadLine()      // 5 4 8 6 3 8 7 7 9
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Stack<int>clothes=new Stack<int>(input);

int capacity =int.Parse(Console.ReadLine());    // 16
int capacityCopy = capacity;

int racksCounter = 1;
while (clothes.Count>0)
{
    
    if (capacity>=clothes.Peek())
    {
        capacity-=clothes.Peek();
        clothes.Pop();
    }
    else
    {
        racksCounter++;
        capacity = capacityCopy;
    }
}

Console.WriteLine(racksCounter);
