List<int> input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

int[] specialNumber = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int bomb = specialNumber[0];
int power = specialNumber[1];

for (int i = 0; i < input.Count; i++)
{
    if (input[i] == bomb)
    {
        int bombIndex = i;


        int startIndex = Math.Max(0, bombIndex - power);
        int endIndex = Math.Min(input.Count - 1, bombIndex + power);

        for (int j = endIndex; j >= startIndex; j--)
        {
            input.RemoveAt(j);
        }


        i = -1;
    }


}
int sum = input.Sum();
Console.WriteLine(sum);