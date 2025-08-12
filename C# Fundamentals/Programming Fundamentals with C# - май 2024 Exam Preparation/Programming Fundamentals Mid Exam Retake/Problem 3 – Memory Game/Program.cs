// See https://aka.ms/new-console-template for more information



List<string> input = Console.ReadLine()        //1 1 2 2 3 3 4 4 5 5 
    .Split(" ")
    .ToList();
string command = "";
int movesCounter = 0;

while ((command = Console.ReadLine()) != "end" && input.Count-1 > 0)      // 1 0 --stringove
{
    string[] tockens = command.Split(" ");
    movesCounter++;

    int index1 = int.Parse(tockens[0]);
    int index2 = int.Parse(tockens[1]);


    if (index1 < 0 || index2 < 0 || index1 == index2 || index1 > input.Count - 1 || index2 > input.Count - 1)
    {
        input.Insert(input.Count / 2, $"-{movesCounter}a");
        input.Insert(input.Count / 2, $"-{movesCounter}a");

        Console.WriteLine("Invalid input! Adding additional elements to the board");
        continue;
    }

    else if (input[index1] != input[index2])
    {
        Console.WriteLine("Try again!");
        continue;
    }
    else if (input[index1] == input[index2])
    {
        string elementToRemove = input[index1];
        Console.WriteLine($"Congrats! You have found matching elements - {input[index1]}!");
        input.Remove(elementToRemove);
        input.Remove(elementToRemove);
        continue;

    }


}
if (input.Count-1 <= 0)
{
    Console.WriteLine($"You have won in {movesCounter} turns!");
    
}

else if (input.Count-1 > 0)
{
    Console.WriteLine("Sorry you lose :(");
    Console.WriteLine(string.Join(" ", input));
}

