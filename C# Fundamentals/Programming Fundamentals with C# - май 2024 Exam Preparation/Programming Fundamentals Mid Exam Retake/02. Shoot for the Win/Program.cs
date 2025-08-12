// See https://aka.ms/new-console-template for more information


List<int> input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();
int countShotTargets = 0;
string command = "";
while ((command = Console.ReadLine()) != "End")
{ 
    int index=int.Parse(command);
    if (index < 0 || index > input.Count - 1)
    {continue;
    }

    if (input[index]==-1)
    {
        continue;
    }
    if (input[index]!=-1)
    {
        countShotTargets++;
        int tempValue = input[index];
        input[index] = -1;


        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] > tempValue && input[i]!=-1)
            {
                input[i] -= tempValue;
            }
            else if (input[i] <= tempValue && input[i] != -1)
            {
                input[i] += tempValue;
            }
        }

        tempValue = 0;
    }



}

Console.WriteLine($"Shot targets: {countShotTargets} -> {string.Join(" ",input)}");
