// See https://aka.ms/new-console-template for more information


Dictionary<string, Dictionary<string, double>> allStores = new Dictionary<string, Dictionary<string, double>>();

string command = "";
while ((command = Console.ReadLine()) != "Revision")
{
    string[] tockens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string store = tockens[0];
    string product= tockens[1];
    double price = double.Parse(tockens[2]);

    if (!allStores.ContainsKey(store))
    {
        allStores.Add(store,new Dictionary<string, double>());
        allStores[store].Add(product, price);
    }
    else
    {
        allStores[store].Add(product,price);
    }

}

allStores = allStores.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

foreach (var store in allStores)
{
    Console.WriteLine($"{store.Key}->");
    foreach (var product in store.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}