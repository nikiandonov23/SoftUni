// See https://aka.ms/new-console-template for more information

Queue<int> bees = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> beeEaters = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

while (bees.Count > 0 && beeEaters.Count > 0)
{
    int currentBee = bees.Dequeue();   //32
    int currentEater = beeEaters.Pop();

    int currentEaterMaxKill = currentEater * 7;  // 

    if (currentBee < currentEaterMaxKill)
    {



        int remainingEaters = (currentEaterMaxKill - currentBee) / 7;
        if ((currentEaterMaxKill - currentBee) % 7 != 0)
        {
            remainingEaters += 1;
        }
        if (beeEaters.Count > 0)
        {
            int eatersToBeAdded = beeEaters.Pop() + remainingEaters;
            beeEaters.Push(eatersToBeAdded);
        }
        else
        {
            beeEaters.Push(remainingEaters);
        }

    }
    else if (currentBee >= currentEaterMaxKill)
    {
        currentBee -= currentEaterMaxKill;
        if (currentBee > 0)
        {
            bees.Enqueue(currentBee);
        }

    }
}

Console.WriteLine("The final battle is over!");
if (beeEaters.Count == 0 && bees.Count == 0)
{
    Console.WriteLine("But no one made it out alive!");
}
else if (bees.Count > 0 && beeEaters.Count == 0)
{
    Console.WriteLine($"Bee groups left: {string.Join(", ", bees)}");
}
else
{
    Console.WriteLine($"Bee-eater groups left: {string.Join(", ", beeEaters)}");
}