int n = int.Parse(Console.ReadLine());


Dictionary<string, Dictionary<string, List<string>>> allKontinents = new Dictionary<string, Dictionary<string, List<string>>>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

    string kontinent=input[0];
    string durjava=input[1];
    string grad=input[2];

    if (allKontinents.ContainsKey(kontinent))
    {
        if (allKontinents[kontinent].ContainsKey(durjava))
        {
            allKontinents[kontinent][durjava].Add(grad);
        }

        else 
        {
            allKontinents[kontinent].Add(durjava,new List<string>());
            allKontinents[kontinent][durjava].Add(grad);
        }
    }
    else
    {
            allKontinents.Add(kontinent,new Dictionary<string, List<string>>());
        allKontinents[kontinent].Add(durjava,new List<string>());
        allKontinents[kontinent][durjava].Add(grad);
    }

}

foreach (var kontinent in allKontinents)
{
    Console.WriteLine($"{kontinent.Key}:");

    foreach (var durjava in kontinent.Value)
    {
        Console.WriteLine($"{durjava.Key} -> {string.Join(", ",durjava.Value)}");
    }
}