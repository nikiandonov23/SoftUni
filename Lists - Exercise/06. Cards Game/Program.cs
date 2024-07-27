// See https://aka.ms/new-console-template for more information



List<int> input1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


    for (int i = 0; i < input1.Count; i++)
    {
        if (input1.Count>0&&input2.Count>0)
        {
        if (input1[i] == input2[i])
        {
            input1.RemoveAt(i);
            input2.RemoveAt(i);
            i--;
        }
        else if (input1[i] > input2[i])
        {
            input1.Add(input1[i]);
            input1.Add(input2[i]);

            input2.RemoveAt(i);
            input1.RemoveAt(i);
            i--;
        }

        else if (input1[i] < input2[i])
        {
            input2.Add(input2[i]);
            input2.Add(input1[i]);

            input2.RemoveAt(i);
            input1.RemoveAt(i);
            i--;
        }
    }
        
    }
    if (input1.Count <= 0)
    {
        Console.WriteLine($"Second player wins! Sum: {input2.Sum()}");
        
    }
    else if (input2.Count <= 0)
    {
        Console.WriteLine($"First player wins! Sum: {input1.Sum()}");
       
    }


