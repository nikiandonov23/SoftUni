List<string> input = Console.ReadLine() // Read initial input
        .Split(" ")
        .ToList();

string command = "";

while ((command = Console.ReadLine()) != "3:1")
{
    string[] tokens = command.Split(" ");

    switch (tokens[0])
    {
        case "merge":
            int startRange = int.Parse(tokens[1]);
            int endRange = int.Parse(tokens[2]);


            if (startRange < 0)
            {
                startRange = 0;
            }

            if (endRange > input.Count - 1)
            {
                endRange = input.Count - 1;
            }


            string mergedString = "";
            for (int i = startRange; i <= endRange; i++)
            {
                mergedString += input[i];
            }

            for (int i = startRange; i <= endRange; i++)
            {
                input.RemoveAt(startRange);
            }
            input.Insert(startRange, mergedString);

            break;

        case "divide":
            int index = int.Parse(tokens[1]);
            int partitions = int.Parse(tokens[2]);

            if (partitions <= 0)
            {
                break;
            }

            string stringToDivide = input[index];
            int partSize = stringToDivide.Length / partitions;


            if (partSize == 0)
            {
                partitions = stringToDivide.Length;
                partSize = 1;
            }

            List<string> result = new List<string>();
            int currentIndex = 0;

            for (int i = 0; i < partitions; i++)
            {
                int currentPartSize = partSize;
                if (i == partitions - 1)
                {
                    currentPartSize += stringToDivide.Length % partitions;
                }
                string part = stringToDivide.Substring(currentIndex, currentPartSize);
                result.Add(part);
                currentIndex += currentPartSize;
            }

            input.RemoveAt(index);
            input.InsertRange(index, result);

            break;
    }

}

Console.WriteLine(string.Join(" ", input));

