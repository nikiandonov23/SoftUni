// See https://aka.ms/new-console-template for more information


Stack<int> fuelQuantity = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


Queue<int> extraFuel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int> altitudes = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int altitudeCount = 0;
int maxAltitude = altitudes.Count;

while (altitudes.Count > 0 && fuelQuantity.Count > 0)
{
    int currentFuel = fuelQuantity.Peek();
    int currentExtra = extraFuel.Peek();
    int currentNeed = altitudes.Peek();

    if (currentFuel - currentExtra >= currentNeed)
    {
        fuelQuantity.Pop();
        extraFuel.Dequeue();
        altitudes.Dequeue();
        altitudeCount++;
        Console.WriteLine($"John has reached: Altitude {altitudeCount}");
    }
    else
    {
        Console.WriteLine($"John did not reach: Altitude {altitudeCount + 1}");
        break;
    }
}
int[] reachedAltitudes = Enumerable.Range(1, altitudeCount).ToArray();
List<string> array = new List<string>();

foreach (var number in reachedAltitudes)
{
    array.Add($"Altitude {number}");
}

if (altitudeCount <= 0)
{
    Console.WriteLine("John failed to reach the top.");
    Console.WriteLine("John didn't reach any altitude.");
}

else if (altitudeCount != maxAltitude)
{
    Console.WriteLine("John failed to reach the top.");
    Console.WriteLine($"Reached altitudes: {string.Join(", ", array)}");

}
else
{
    Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
}
