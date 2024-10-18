// See https://aka.ms/new-console-template for more information

Queue<int>coffee=new Queue<int>(Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> milk=new Stack<int>(Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Dictionary<string,int>drinksMade=new Dictionary<string,int>()
{
    {"Cortado",0},   //50
    {"Espresso",0},   //75
    {"Capuccino",0},   //100
    {"Americano",0},   //150
    {"Latte",0},      //200

};


while (coffee.Count > 0 && milk.Count > 0)
{
    int currentCofee = coffee.Peek();
    int currentMilk=milk.Peek();
    int currentSum = currentCofee + currentMilk;

    switch (currentSum)
    {
        case 50 :
            drinksMade["Cortado"] += 1;
            coffee.Dequeue();
            milk.Pop();
            break;

        case 75:
            drinksMade["Espresso"] += 1;
            coffee.Dequeue();
            milk.Pop();
            break;

        case 100:
            drinksMade["Capuccino"] += 1;
            coffee.Dequeue();
            milk.Pop();
            break;

        case 150:
            drinksMade["Americano"] += 1;
            coffee.Dequeue();
            milk.Pop();
            break;

        case 200:
            drinksMade["Latte"] += 1;
            coffee.Dequeue();
            milk.Pop();
            break;


        default:
            coffee.Dequeue();

            milk.Push(milk.Pop()-5);
            break;
    }

}

drinksMade=drinksMade.Where(x=>x.Value>0).ToDictionary(x=>x.Key,x=>x.Value);
drinksMade = drinksMade.OrderBy(x => x.Value).ThenByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

if (coffee.Count==0&&milk.Count==0)
{
    Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
}
else if (coffee.Count > 0 || milk.Count > 0)
{
    Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
}


if (coffee.Count==0)
{
    Console.WriteLine("Coffee left: none");
}
else if (coffee.Count>0)
{
    Console.WriteLine($"Coffee left: {string.Join(", ",coffee)}");
}


if (milk.Count == 0)
{
    Console.WriteLine("Milk left: none");
}
else if (milk.Count > 0)
{
    Console.WriteLine($"Milk left: {string.Join(", ",milk)}");
}


if (drinksMade.Count>0)
{
    foreach (var drink in drinksMade)
    {
        Console.WriteLine($"{drink.Key}: {drink.Value}");
    }
}

