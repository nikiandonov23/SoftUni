int n = int.Parse(Console.ReadLine());


Queue<int[]> allStations = new Queue<int[]>();
for (int i = 0; i < n; i++)
{

    int[] currentStation = Console.ReadLine()
        .Split(" ")
        .Select(int.Parse)
        .ToArray();
    allStations.Enqueue(currentStation);

}

for (int i = 0; i < n; i++)
{
    if (canFinish(allStations))
    {
        Console.WriteLine(i);
        break;
    }
    allStations.Enqueue(allStations.Dequeue());
}

static bool canFinish(Queue<int[]> allStations)
{
    int fuel = 0;
    bool canFinishTheTrip = true;

    foreach (var station in allStations)
    {
        fuel += station[0] - station[1];
        if (fuel<0)
        {
            canFinishTheTrip=false;
            break;
        }

        
    }
    return canFinishTheTrip;
}