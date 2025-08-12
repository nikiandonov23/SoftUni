// See https://aka.ms/new-console-template for more information


Stack<int> whiteTiles =
    new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int> greyTiles =
    new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


Dictionary<string, int> decoratedLocations = new Dictionary<string, int>()
{
    { "Sink", 0 },
    { "Oven", 0 },
    { "Countertop", 0 },
    { "Wall", 0 },
    { "Floor", 0 },

};




int floor = 0;
while (whiteTiles.Count>0&&greyTiles.Count>0)
{
    bool weHavematch = false;

    int currentWhite = whiteTiles.Peek();
    int currentGrey = greyTiles.Peek();
    int currentSum = 0;

    if (currentWhite == currentGrey)
    {
        weHavematch = true;
        currentSum = currentWhite + currentGrey;
    }

    if (weHavematch)
    {
        whiteTiles.Pop();
        greyTiles.Dequeue();

        switch (currentSum)
        {
            case 40:
                decoratedLocations["Sink"] += 1;
                break;

            case 50:
                decoratedLocations["Oven"] += 1;
                break;

            case 60:
                decoratedLocations["Countertop"] += 1;
                break;

            case 70:
                decoratedLocations["Wall"] += 1;
                break;

            default:
                decoratedLocations["Floor"] += 1;
                break;
        }
   
    }
    else
    {
        whiteTiles.Push(whiteTiles.Pop()/2);
        greyTiles.Enqueue(greyTiles.Dequeue());
    }
}

if (whiteTiles.Count>0)
{
    Console.WriteLine($"White tiles left: {string.Join(", ",whiteTiles)}");
}
if (whiteTiles.Count==0)
{
    Console.WriteLine("White tiles left: none");
}



if (greyTiles.Count == 0)
{
    Console.WriteLine("Grey tiles left: none");
}
if (greyTiles.Count>0)
{
    Console.WriteLine($"Grey tiles left: {string.Join(", ",greyTiles)}");
}


decoratedLocations = decoratedLocations.Where(x => x.Value != 0).ToDictionary(x => x.Key, y => y.Value);
var finalPrint =decoratedLocations.OrderByDescending(x=>x.Value).ThenBy(y=>y.Key);

foreach (var element in finalPrint)
{
    Console.WriteLine($"{element.Key}: {element.Value}");
}