// See https://aka.ms/new-console-template for more information


using System.ComponentModel.Design;

Queue<int> times=new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> tasks=new Stack<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Dictionary<string, int> DuckType = new Dictionary<string, int>()
{
    {"Darth Vader Ducky", 0 },
    {"Thor Ducky",0},
    {"Big Blue Rubber Ducky",0},
    {"Small Yellow Rubber Ducky",0}
};


while (times.Count>0&&tasks.Count>0)
{
    int currentTime = times.Dequeue();
    int currentTask = tasks.Pop();

    if (currentTime*currentTask>=0&&currentTime*currentTask<=240)
    {
        if (currentTime*currentTask>=0&&currentTime*currentTask<=60)
        {
            DuckType["Darth Vader Ducky"] += 1;
        }

        else if (currentTime * currentTask >= 61&& currentTime * currentTask <=120)
        {
            DuckType["Thor Ducky"] += 1;

        }
        else if (currentTime * currentTask >= 121 && currentTime * currentTask <= 180)
        {
            DuckType["Big Blue Rubber Ducky"] += 1;

        }
        else
        {
            DuckType["Small Yellow Rubber Ducky"] += 1;

        }
    }
    else
    {
        currentTask -= 2;
        tasks.Push(currentTask);

        times.Enqueue(currentTime);
    }
}

Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
foreach (var duck in DuckType)
{
    Console.WriteLine($"{duck.Key}: {duck.Value}");
}