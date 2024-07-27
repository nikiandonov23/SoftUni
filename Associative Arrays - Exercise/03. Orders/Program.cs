// See https://aka.ms/new-console-template for more information


Dictionary<string,List<double>> products=new Dictionary<string,List<double>>();  //string {name}            List<double> {price} {quantity}


string input = "";
while ((input = Console.ReadLine()) != "buy")
{
    string[] tockens = input.Split(" ");

    string name = tockens[0];
    double price = double.Parse(tockens[1]);
    double quantity=double.Parse(tockens[2]);

    if (!products.ContainsKey(name))
    {
        products.Add(name, new List<double>(){price,quantity});    //vkarvam v lista {price} {quantity}
    }
    else 
    {
        List<double>currentValues=products[name];

        currentValues[0]= price;
        currentValues[1]+= quantity;

    }
}

foreach (var element in products)
{
    double totalPrice = element.Value[0]*element.Value[1];

    Console.WriteLine($"{element.Key} -> {totalPrice:f2}");
}
