// See https://aka.ms/new-console-template for more information


int[] n=Console.ReadLine().Split(" ",StringSplitOptions.None).Select(int.Parse).ToArray();

HashSet<int>firstSet = new HashSet<int>();
HashSet<int>secondSet=new HashSet<int>();
for (int i = 0; i < n[0]; i++)
{
    int currentNum=int.Parse(Console.ReadLine());
    firstSet.Add(currentNum);

}

for (int i = 0; i < n[1]; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    secondSet.Add(currentNum);

}
HashSet<int>toBePrinted=new HashSet<int>();
foreach (var number in firstSet)
{
    if (secondSet.Contains(number))
    {
        toBePrinted.Add(number);
    }
}

Console.WriteLine(string.Join(" ",toBePrinted));