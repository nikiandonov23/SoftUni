// See https://aka.ms/new-console-template for more information


Stack<int> strenght=new Stack<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int> accuracy = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
int goals = 0;

while (strenght.Count>0&&accuracy.Count>0)
{
    int currentStrenght = strenght.Peek();
    int currentAccuracy = accuracy.Peek();
    int currentSum = currentStrenght + currentAccuracy;


    if (currentSum==100)
    {
        goals++;
        strenght.Pop();
        accuracy.Dequeue();
    }
    else if (currentSum>100)
    {
     strenght.Push(strenght.Pop()-10);
     accuracy.Enqueue(accuracy.Dequeue());
    }
    else if (currentSum<100)
    {
        if (currentStrenght < currentAccuracy)
        {
            strenght.Pop();
        }
        else if (currentStrenght > currentAccuracy)
        {
            accuracy.Dequeue();
        }
        else if (currentStrenght == currentAccuracy)
        {
            strenght.Push(strenght.Pop() + accuracy.Dequeue());
        }
    }
}

if (goals==3)
{
    Console.WriteLine("Paul scored a hat-trick!");
}

if (goals==0)
{
    Console.WriteLine("Paul failed to score a single goal.");
}

if (goals>3)
{
    Console.WriteLine("Paul performed remarkably well!");
}

if (goals>0&&goals<3)
{
    Console.WriteLine("Paul failed to make a hat-trick.");
}

if (goals>0)
{
    Console.WriteLine($"Goals scored: {goals}");
}

if (strenght.Count>0||accuracy.Count>0)
{
    if (strenght.Count>0)
    {
        Console.WriteLine($"Strength values left: {string.Join(", ",strenght)}");
    }

    if (accuracy.Count>0)
    {
        Console.WriteLine($"Accuracy values left: {string.Join(", ",accuracy)}");
    }
}