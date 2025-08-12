// See https://aka.ms/new-console-template for more information



List<int> input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

bool isChanged = false;

string command = "";
while ((command = Console.ReadLine()) != "end")
{
    string[] tockens = command.Split(" ");

    switch (tockens[0])
    {
        case "Add":
            input.Add(int.Parse(tockens[1]));
            isChanged = true;
            break;
        case "Remove":
            input.Remove(int.Parse(tockens[1]));
            isChanged = true;

            break;
        case "RemoveAt":
            input.RemoveAt(int.Parse(tockens[1]));
            isChanged = true;

            break;
        case "Insert":
            input.Insert(int.Parse(tockens[2]), int.Parse(tockens[1]));
            isChanged = true;

            break;

        case "Contains":
            input.Contains(int.Parse(tockens[1]));
            if (input.Contains(int.Parse(tockens[1])))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }

            break;
        case "PrintEven":
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    Console.Write(input[i] + " ");
                }
            }

            Console.WriteLine();

            break;


        case "PrintOdd":
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 != 0)
                {
                    Console.Write(input[i] + " ");
                }
            }

            Console.WriteLine();
            break;


        case "GetSum":
            int sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum += input[i];
            }

            Console.WriteLine(sum);
            break;


        case "Filter":
            string condition = tockens[1];
            int number = int.Parse(tockens[2]);

            if (condition == "<")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] < number)
                    {
                        Console.Write(input[i] + " ");
                    }
                }

                Console.WriteLine();
            }

            else if (condition == "<=")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= number)
                    {
                        Console.Write(input[i] + " ");
                    }
                }

                Console.WriteLine();
            }

            else if (condition == ">")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] > number)
                    {
                        Console.Write(input[i] + " ");
                    }
                }

                Console.WriteLine();
            }

            else if (condition == ">=")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] >= number)
                    {
                        Console.Write(input[i] + " ");
                    }
                }

                Console.WriteLine();
            }
            break;
             

    }
}

if (isChanged)
{
    Console.WriteLine(string.Join(" ", input));
}