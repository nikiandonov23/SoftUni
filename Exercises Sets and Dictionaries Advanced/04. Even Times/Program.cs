// See https://aka.ms/new-console-template for more information


int n = int.Parse(Console.ReadLine());

Dictionary<int,int>allNumbers=new Dictionary<int, int>();
for (int i = 0; i < n; i++)
{
    int input=int.Parse(Console.ReadLine());

    if (!allNumbers.ContainsKey(input))
    {
        allNumbers.Add(input,1);
    }
    else
    {
        allNumbers[input] += 1;
    }
}

foreach (var number in allNumbers)
{
    if (number.Value%2==0)
    {
        Console.WriteLine(number.Key);
        
    }
}