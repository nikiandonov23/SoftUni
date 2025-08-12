// See https://aka.ms/new-console-template for more information


int n = int.Parse(Console.ReadLine());


Dictionary<string, Dictionary<string, List<string>>> allContinents = new Dictionary<string, Dictionary<string, List<string>>>();
for (int i = 0; i < n; i++)
{
    string[] tockens=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
    string continent = tockens[0];
    string country = tockens[1];
    string city = tockens[2];


    if (!allContinents.ContainsKey(continent))   //ako nqma kontinent suzdavam go 
    {
        allContinents.Add(continent,new Dictionary<string, List<string>>());
        allContinents[continent].Add(country,new List<string>());
        allContinents[continent][country].Add(city);
    }
    else   // ako ima kontinent 
    {
        if (allContinents[continent].ContainsKey(country))    //ako durjavata sushtestvuva dobavqm grada v tazi darjava
        {
            allContinents[continent][country].Add(city);
        }
        else if (!allContinents[continent].ContainsKey(country))   //ako durjavata ne sushtestvuva dobavqm durjavata i grada vutre v neq
        {
            allContinents[continent].Add(country,new List<string>());
            allContinents[continent][country].Add(city);
        }
    }
}

foreach (var continent in allContinents)
{
    Console.WriteLine($"{continent.Key}:");

    foreach (var country in continent.Value)
    {
        Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
    }
 
}