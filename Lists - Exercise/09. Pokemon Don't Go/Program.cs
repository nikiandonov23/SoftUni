List<int> input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

int sum = 0;

while (input.Count > 0)
{
    int index = int.Parse(Console.ReadLine());

    if (index > input.Count - 1)
    {
        int numberToBeCompared = input[input.Count - 1];
        sum += numberToBeCompared;
        input.RemoveAt(input.Count - 1);
        if (input.Count > 0)                                   
        {
            int numberCopy = input[0];
            input.Add(numberCopy);
        }
        
        for (int i = 0; i < input.Count; i++)
        {
            if (numberToBeCompared >= input[i])
            {
                input[i] += numberToBeCompared;
            }
            else
            {
                input[i] -= numberToBeCompared;
            }
        }
    }
    else if (index < 0)
    {
        int numberToBeCompared = input[0];
        sum += numberToBeCompared;
        input.RemoveAt(0);
        if (input.Count > 0) 
        {
            int numberCopy = input[input.Count - 1];
            input.Insert(0, numberCopy);
        }
        
        for (int i = 0; i < input.Count; i++)
        {
            if (numberToBeCompared >= input[i])
            {
                input[i] += numberToBeCompared;
            }
            else
            {
                input[i] -= numberToBeCompared;
            }
        }
    }
    else
    {
        int numberToBeCompared = input[index];
        sum += numberToBeCompared;
        input.RemoveAt(index);
        for (int i = 0; i < input.Count; i++)
        {
            if (numberToBeCompared >= input[i])
            {
                input[i] += numberToBeCompared;
            }
            else
            {
                input[i] -= numberToBeCompared;
            }
        }
    }
}

Console.WriteLine(sum);