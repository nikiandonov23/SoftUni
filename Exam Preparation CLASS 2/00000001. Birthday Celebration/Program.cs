// See https://aka.ms/new-console-template for more information

Queue<int> guests = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> plates = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int totalWaste = 0;

while (guests.Count > 0 && plates.Count > 0)
{
    int currentGuest = guests.Dequeue();
    int currentPlate = plates.Pop();

    int currentWaste = 0;
    if (currentPlate >= currentGuest)
    {
        currentWaste = currentPlate - currentGuest;
        totalWaste += currentWaste;
        continue;

    }

    if (currentGuest>currentPlate)
    {
        currentGuest -= currentPlate;

        while (currentGuest>0)
        {
            int previousValue = currentGuest;
            currentPlate = plates.Pop();
            currentGuest -= currentPlate;
            if (currentGuest <= 0)
            {
                totalWaste += currentPlate - previousValue;
            }
        }
    }
    
}

if (guests.Count>0||plates.Count>0)
{
    if (guests.Count>0)
    {
        Console.WriteLine($"Guests: {string.Join(" ",guests)}");
    }
    else if (plates.Count>0)
    {
        Console.WriteLine($"Plates: {string.Join(" ",plates)}");
    }
}

Console.WriteLine($"Wasted grams of food: {totalWaste}");