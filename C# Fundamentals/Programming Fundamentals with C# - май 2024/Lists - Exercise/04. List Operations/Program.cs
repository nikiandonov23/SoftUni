// See https://aka.ms/new-console-template for more information


List<int> input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();
string command = "";

while ((command = Console.ReadLine()) != "End")
{
    string[] tockens = command.Split(" ");

    switch (tockens[0])
    {
        case "Add":
            input.Add(int.Parse(tockens[1]));
            break;

        case "Insert":

            if (int.Parse(tockens[2]) >= input.Count || int.Parse(tockens[2])<0)
            {
                Console.WriteLine("Invalid index");
                break;
            }

            input.Insert(int.Parse(tockens[2]), int.Parse(tockens[1]));
            break;



        case "Remove":
            if (int.Parse(tockens[1]) >= input.Count || int.Parse(tockens[1])<0)
            {
                Console.WriteLine("Invalid index");
                break;
            }
            input.RemoveAt(int.Parse(tockens[1]));
            break;

        case "Shift":
            if (tockens[1] == "left")
            {
                for (int i = 0; i < int.Parse(tockens[2]); i++)
                {
                    input.Insert(input.Count, (input[0]));
                    input.RemoveAt(0);
                }
            }
            if (tockens[1] == "right")
            {
                for (int i = 0; i < int.Parse(tockens[2]); i++)
                {

                    input.Insert(0, (input[input.Count - 1]));
                    input.RemoveAt(input.Count - 1);

                }
            }

            break;
    }
}

Console.WriteLine(string.Join(" ", input));