// See https://aka.ms/new-console-template for more information


List<int> input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();
int max = int.Parse(Console.ReadLine());

string command = "";

while ((command = Console.ReadLine()) != "end")
{
    string[] tockens = command.Split();

    if (tockens[0] == "Add")
    {
        input.Add(int.Parse(tockens[1]));
    }
    else
    {

        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] + int.Parse(tockens[0]) <= max)
            {
                input[i] += int.Parse(tockens[0]);
                break;
            }
        }
    }





}

Console.WriteLine(String.Join(" ", input));