// See https://aka.ms/new-console-template for more information


string command = "";
HashSet<string> allcars = new HashSet<string>();

while ((command = Console.ReadLine()) != "END")
{
    string[] tockens=command.Split(", ",StringSplitOptions.RemoveEmptyEntries).ToArray();
    string direction = tockens[0];
    string licensePlate=tockens[1];

    switch (direction)
    {
        case "IN":
            allcars.Add(licensePlate);
            break;




        case "OUT":
            allcars.Remove(licensePlate);
            break;
    }
}

if (allcars.Count>0)
{
    foreach (var car in allcars)
    {
        Console.WriteLine($"{car}");
    }
}
else
{
    Console.WriteLine($"Parking Lot is Empty");
}