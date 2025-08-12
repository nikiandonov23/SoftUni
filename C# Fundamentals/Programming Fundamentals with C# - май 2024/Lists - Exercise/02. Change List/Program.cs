// See https://aka.ms/new-console-template for more information



List<int> input=Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

string command="";

while ((command=Console.ReadLine()) !="end")
{
    string[] tockens = command.Split(" ");

    switch (tockens[0])
    {
        case "Delete":

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == int.Parse(tockens[1]))
                {
                    input.RemoveAt(i);
                }
            }

            break;

        case "Insert":
            input.Insert(int.Parse(tockens[2]), int.Parse(tockens[1]));
            break;
    }
}

Console.WriteLine(string.Join(" ",input));