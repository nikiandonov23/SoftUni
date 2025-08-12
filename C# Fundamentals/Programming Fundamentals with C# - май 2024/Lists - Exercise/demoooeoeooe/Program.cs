using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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

            if (startRange < input.Count && endRange >= 0 && startRange < endRange)
            {
                StringBuilder mergedString = new StringBuilder();
                for (int i = startRange; i <= endRange; i++)
                {
                    mergedString.Append(input[i]);
                }

                for (int i = startRange; i <= endRange; i++)
                {
                    input.RemoveAt(startRange);
                }

                input.Insert(startRange, mergedString.ToString());
            }
            break;

        case "divide":
            int index = int.Parse(tokens[1]);
            int partitions = int.Parse(tokens[2]);

            if (partitions <= 0 || index < 0 || index >= input.Count)
            {
                break;
            }

            string stringToDivide = input[index];
            int partSize = stringToDivide.Length / partitions;
            int extraChars = stringToDivide.Length % partitions;

            List<string> result = new List<string>();
            int currentIndex = 0;

            for (int i = 0; i < partitions; i++)
            {
                int currentPartSize = partSize + (i < extraChars ? 1 : 0);
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

