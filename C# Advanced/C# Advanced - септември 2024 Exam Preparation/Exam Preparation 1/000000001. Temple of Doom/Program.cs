// See https://aka.ms/new-console-template for more information

Queue<int> tools = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> substances = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

List<int> challanges = new List<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


while (tools.Count > 0 && substances.Count > 0)
{
    int currentTool = tools.Peek();
    int currentSubstance = substances.Peek();

    if (challanges.Contains(currentTool * currentSubstance))
    {
        tools.Dequeue();
        substances.Pop();
        challanges.Remove(currentTool * currentSubstance);

    }
    else if (!challanges.Contains(currentTool * currentSubstance))
    {
        currentTool += 1;
        tools.Dequeue();
        tools.Enqueue(currentTool);



        currentSubstance -= 1;
        if (currentSubstance <= 0)
        {
            substances.Pop();
        }
        else
        {
            substances.Pop();
            substances.Push(currentSubstance);
        }
    }



    if (substances.Count <= 0 && challanges.Count > 0)
    {
        Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
        break;
    }
    if (challanges.Count <= 0)
    {
        Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
    }

}

if (tools.Count>0)
{
    Console.WriteLine($"Tools: {string.Join(", ",tools)}");
}

if (substances.Count>0)
{
    Console.WriteLine($"Substances: {string.Join(", ",substances)}");
}

if (challanges.Count>0)
{
    Console.WriteLine($"Challenges: {string.Join(", ",challanges)}");
}


