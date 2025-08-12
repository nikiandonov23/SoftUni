// See https://aka.ms/new-console-template for more information



Dictionary<string, List<string>> allEmployees = new Dictionary<string, List<string>>();


string input = "";
while ((input = Console.ReadLine()) != "End")
{
    string[] tockens = input.Split(" -> ");

    string companyName = tockens[0];
    string ID= tockens[1];

    if (!allEmployees.ContainsKey(companyName))
    {
        allEmployees.Add(companyName, new List<string>(){ID});
    }
    else
    {
        if (allEmployees.ContainsKey(companyName))
        {
            if (allEmployees[companyName].Contains(ID))
            {
                continue;
            }
            else
            {
                allEmployees[companyName].Add(ID);
            }
        }

    }

}

foreach (var element in allEmployees)
{
    Console.WriteLine(element.Key);

    foreach (var id in element.Value)
    {
        Console.WriteLine($"-- {id}");
    }
}
