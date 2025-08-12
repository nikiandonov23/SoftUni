// See https://aka.ms/new-console-template for more information


Queue<double> waters=new Queue<double>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));


Stack<double> flours=new Stack<double>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));

Dictionary<string, int> products = new Dictionary<string, int>()
{
    {"Croissant",0},
    {"Muffin",0},
    {"Baguette",0},
    {"Bagel",0},
};
while (flours.Count>0&&waters.Count>0)
{
    double currentWater = waters.Peek();
    double currentFlour = flours.Peek();

    double currentProcWater = currentWater * 100 / (currentWater + currentFlour);
    double currentProcFlour = 100 - currentProcWater;

    switch ((currentProcWater,currentProcFlour))
    {
        case (40,60) :
            products["Muffin"] += 1;
            waters.Dequeue();
            flours.Pop();
            break;

        case (30, 70):
            products["Baguette"] += 1;
            waters.Dequeue();
            flours.Pop();
            break;

        case (20, 80):
            products["Bagel"] += 1;
            waters.Dequeue();
            flours.Pop();
            break;

        case (50, 50):
            products["Croissant"] += 1;
            waters.Dequeue();
            flours.Pop();
            break;


        default:
            double flourToReturn = currentFlour - currentWater;
            waters.Dequeue();
            flours.Pop();

           
            
                flours.Push(flourToReturn);
            

            products["Croissant"] += 1;
            Console.WriteLine();
            break;
    }
}


var sortedProducts=products.
    Where(x=>x.Value>0)
    .OrderByDescending(y=>y.Value)
    .ThenBy(j=>j.Key)
    .ToDictionary(x=>x.Key,x=>x.Value);

foreach (var product in sortedProducts)
{

    Console.WriteLine($"{product.Key}: {product.Value}");
}

if (waters.Count>0)
{
    Console.WriteLine($"Water left: {string.Join(", ",waters)}");
}
else if (waters.Count == 0)
{
    Console.WriteLine("Water left: None");
}


if (flours.Count>0)
{
    Console.WriteLine($"Flour left: {string.Join(", ", flours)}");
}
else if (flours.Count == 0)
{
    Console.WriteLine("Flour left: None");
}



