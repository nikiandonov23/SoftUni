// See https://aka.ms/new-console-template for more information


string resources = "";
int quantity = 0;


Dictionary<string,int> resourceQuantity=new Dictionary<string,int>();

while ((resources = Console.ReadLine()) != "stop")
{
    quantity = int.Parse(Console.ReadLine());

    if (!resourceQuantity.ContainsKey(resources))
    {
        resourceQuantity.Add(resources, quantity);
    }
    else
    {
        resourceQuantity[resources] += quantity;
    }
}

foreach (var element in resourceQuantity)
{
    Console.WriteLine($"{element.Key} -> {element.Value}");
}