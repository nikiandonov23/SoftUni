// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

Queue<int> textiles=new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> medicaments=new Stack<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Dictionary<string, int> healingItems = new Dictionary<string, int>()
{
    {"Patch",0},  //30
    {"Bandage",0}, //40
    {"MedKit",0}  //100
};

while (textiles.Count>0&&medicaments.Count>0)
{
 

    int currentTextile = textiles.Peek();
    int currentMedicament = medicaments.Peek();
    int sum = currentTextile + currentMedicament;

    if (sum == 30)
    {
        healingItems["Patch"] += 1;
        textiles.Dequeue();
        medicaments.Pop();
    }
    else if (sum == 40)
    {
        healingItems["Bandage"] += 1;
        textiles.Dequeue();
        medicaments.Pop();
    }
    else if (sum == 100)
    {
        healingItems["MedKit"] += 1;
        textiles.Dequeue();
        medicaments.Pop();
    }
    else if (sum > 100)
    {
        healingItems["MedKit"] += 1;
        int leftover = sum - 100;
        textiles.Dequeue();
        medicaments.Pop();

        
        if (medicaments.Count > 0)
        {
            medicaments.Push(medicaments.Pop() + leftover);
        }
        else
        {
            medicaments.Push(leftover); 
        }
    }
    else
    {
        textiles.Dequeue();
        medicaments.Push(medicaments.Pop() + 10); 
    }

}

if (medicaments.Count == 0 && textiles.Count == 0)
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (medicaments.Count == 0)
{
    Console.WriteLine("Medicaments are empty.");
}
else if (textiles.Count == 0)
{
    Console.WriteLine("Textiles are empty.");
}


if (healingItems.Any(x => x.Value > 0))
{
    foreach (var item in healingItems.Where(x => x.Value > 0)
                 .OrderByDescending(x => x.Value)
                 .ThenBy(x => x.Key))
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}

if (medicaments.Count > 0)
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}

if (textiles.Count > 0)
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
}