// See https://aka.ms/new-console-template for more information


List<int> input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

string command = "";
while ((command = Console.ReadLine()) != "End")
{
    string[] tockens = command.Split(" ");
    int index = 0;

    switch (tockens[0])
    {
        case "Shoot":
            index = int.Parse(tockens[1]);
            int power = int.Parse(tockens[2]);


            if (index >= 0 && index < input.Count)
            {
                input[index] -= power;
                if (input[index] <= 0)
                {
                    input.RemoveAt(index);
                }
            }

            break;



        case "Add":
            index = int.Parse(tockens[1]);
            int value = int.Parse(tockens[2]);

            if (index >= 0 && index < input.Count)
            {
                input.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
               
            }
            break;



        case "Strike":
            index = int.Parse(tockens[1]);
            int radius = int.Parse(tockens[2]);

            int startRange = index - radius;
            int endRange = index + radius;

            if (startRange >= 0 && endRange < input.Count)
            {
                input.RemoveRange(startRange, radius * 2 + 1);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
            break;
            
    }
}

Console.WriteLine(string.Join("|", input));