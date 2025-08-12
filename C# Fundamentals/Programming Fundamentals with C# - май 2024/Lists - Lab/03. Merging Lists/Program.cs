// See https://aka.ms/new-console-template for more information



List<int> list1 = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

List<int> list2 = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

List<int> result = new List<int>();


int count = 0;
if (list1.Count > list2.Count)
{
    count = list1.Count;
}
else
{
    count = list2.Count;
}

for (int i = 0; i < count; i++)
{

    if (i<list1.Count)
    {
        result.Add(list1[i]); 
    }

    if (i<list2.Count)
    {
        result.Add(list2[i]);
    }
}


Console.WriteLine(string.Join(" ", result));
